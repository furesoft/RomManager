using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Extensions.Options;
using RomManager.Configurations;
using RomManager.Models;
using RomManager.Models.FileTypes;

namespace RomManager.Core;

public sealed class CollectionCatalog
{
    private const string CollectionPrefix = "custom-";
    private const string RomPathToken = "%ROMPATH%";

    public CollectionCatalog(RomManager romManager, IOptions<PathsConfiguration> pathsConfiguration)
    {
        ArgumentNullException.ThrowIfNull(romManager);
        ArgumentNullException.ThrowIfNull(pathsConfiguration);

        Collections = LoadCollections(romManager.Games, pathsConfiguration.Value);
    }

    public IReadOnlyList<GameCollection> Collections { get; }

    private static IReadOnlyList<GameCollection> LoadCollections(IReadOnlyList<Game> games, PathsConfiguration paths)
    {
        var collectionsDirectory = Path.Combine(paths.BasePath, "ES-DE", "collections");
        if (!Directory.Exists(collectionsDirectory)) return [];

        var romRootDirectory = Path.Combine(paths.BasePath, paths.Roms);
        var gamesByRomPath = games
            .SelectMany(game => game.Files.OfType<RomFile>().Select(file => (Game: game, Path: NormalizePath(file.Filename))))
            .Where(item => !string.IsNullOrWhiteSpace(item.Path))
            .GroupBy(item => item.Path, StringComparer.OrdinalIgnoreCase)
            .ToDictionary(group => group.Key, group => group.First().Game, StringComparer.OrdinalIgnoreCase);

        var collectionFiles = Directory
            .EnumerateFiles(collectionsDirectory, "custom-*.cfg", SearchOption.TopDirectoryOnly)
            .OrderBy(path => path, StringComparer.OrdinalIgnoreCase);

        var collections = new List<GameCollection>();

        foreach (var filePath in collectionFiles)
        {
            var collectionName = GetCollectionName(filePath);
            var collectionGames = new List<Game>();
            var seenGames = new HashSet<Game>();

            foreach (var line in File.ReadLines(filePath))
            {
                var resolvedPath = ResolveRomPath(line, romRootDirectory);
                if (resolvedPath is null) continue;
                if (!gamesByRomPath.TryGetValue(resolvedPath, out var game)) continue;
                if (!seenGames.Add(game)) continue;

                collectionGames.Add(game);
            }

            collections.Add(new GameCollection
            {
                Name = collectionName,
                Games = collectionGames
            });
        }

        return collections;
    }

    private static string GetCollectionName(string filePath)
    {
        var nameWithoutExtension = Path.GetFileNameWithoutExtension(filePath);
        return nameWithoutExtension.StartsWith(CollectionPrefix, StringComparison.OrdinalIgnoreCase)
            ? nameWithoutExtension[CollectionPrefix.Length..]
            : nameWithoutExtension;
    }

    private static string? ResolveRomPath(string line, string romRootDirectory)
    {
        if (string.IsNullOrWhiteSpace(line)) return null;

        var trimmedLine = line.Trim();
        var normalizedRoot = NormalizePath(romRootDirectory);

        if (trimmedLine.StartsWith(RomPathToken, StringComparison.OrdinalIgnoreCase))
        {
            var relativePath = trimmedLine[RomPathToken.Length..].TrimStart('/', '\\');
            var combinedPath = Path.Combine(normalizedRoot, relativePath);
            return NormalizePath(combinedPath);
        }

        if (Path.IsPathRooted(trimmedLine)) return NormalizePath(trimmedLine);

        return NormalizePath(Path.Combine(normalizedRoot, trimmedLine));
    }

    private static string NormalizePath(string path)
    {
        return path
            .Trim()
            .Replace('/', Path.DirectorySeparatorChar)
            .Replace('\\', Path.DirectorySeparatorChar);
    }
}
