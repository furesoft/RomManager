using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using RomManager.Configurations;
using RomManager.Models.FileTypes;

namespace RomManager.Models;

public abstract class SystemInfo
{
    public abstract string Name { get; }
    public abstract string Path { get; }
    public abstract string[] Extensions { get; }

    public abstract string? IconName { get; }

    public GameList GameList { get; set; }

    public override string ToString()
    {
        return Name;
    }

    public bool IsReachable(PathsConfiguration pathsConfiguration)
    {
        return Directory.Exists(GetDirectory(pathsConfiguration));
    }

    public bool HasGames(PathsConfiguration pathsConfiguration)
    {
        if (!IsReachable(pathsConfiguration)) return false;

        var folderPath = System.IO.Path.Combine(pathsConfiguration.BasePath, pathsConfiguration.Roms, Path);

        var roms = Directory.EnumerateFiles(folderPath, "*", SearchOption.AllDirectories)
            .Where(file => Extensions.Contains(System.IO.Path.GetExtension(file).ToLower()));

        return roms.Any();
    }

    public string GetDirectory(PathsConfiguration pathsConfiguration)
    {
        var folderPath = System.IO.Path.Combine(pathsConfiguration.BasePath, pathsConfiguration.Roms, Path);
        return folderPath;
    }

    public List<Game> GetGames(PathsConfiguration pathsConfiguration)
    {
        if (!IsReachable(pathsConfiguration)) return [];

        var folderPath = System.IO.Path.Combine(pathsConfiguration.BasePath, pathsConfiguration.Roms, Path);

        var roms = Directory.EnumerateFiles(folderPath, "*", SearchOption.AllDirectories)
            .Where(file => Extensions.Contains(System.IO.Path.GetExtension(file).ToLower()));

        var games =
            from file in roms
            select GetGame(pathsConfiguration, file);

        return games.ToList();
    }

    private Game GetGame(PathsConfiguration pathsConfiguration, string file)
    {
        GameInfo gameInfo;
        if (!GameList.GamesByFilename.TryGetValue(System.IO.Path.GetFileName(file), out gameInfo))
            gameInfo = new GameInfo { Path = file, Name = System.IO.Path.GetFileNameWithoutExtension(file) };

        return new Game { Info = gameInfo, Files = GetFiles(pathsConfiguration, file).ToArray() };
    }

    private IEnumerable<IHasFilename> GetFiles(PathsConfiguration pathsConfiguration, string romFilename)
    {
        yield return new RomFile { Filename = romFilename, SystemInfo = this };

        var name = System.IO.Path.GetFileNameWithoutExtension(romFilename);
        var mediaPath = System.IO.Path.Combine(pathsConfiguration.BasePath, pathsConfiguration.Media, Path);
        if (!Directory.Exists(mediaPath)) yield break;

        foreach (var mediaType in GetMediaTypes())
        {
            var file = FindMediaFile(mediaPath, mediaType.Directories, name);
            if (file is not null) yield return mediaType.Factory(file);
        }
    }

    private static IEnumerable<(string[] Directories, Func<string, IHasFilename> Factory)> GetMediaTypes()
    {
        yield return (["covers"], filename => new CoverArtImage { Filename = filename });
        yield return (["videos"], filename => new Video { Filename = filename });
        yield return (["manuals"], filename => new Manual { Filename = filename });
        yield return (["screenshots"], filename => new Screenshot { Filename = filename });
        yield return (["titlescreens"], filename => new TitleScreen { Filename = filename });
        yield return (["states"], filename => new State { Filename = filename });
    }

    private static string? FindMediaFile(string mediaPath, IEnumerable<string> mediaDirectories, string romName)
    {
        foreach (var mediaDirectory in mediaDirectories)
        {
            var mediaDirectoryPath = System.IO.Path.Combine(mediaPath, mediaDirectory);
            if (!Directory.Exists(mediaDirectoryPath)) continue;

            var exactPattern = mediaDirectory.Equals("states", StringComparison.OrdinalIgnoreCase)
                ? $"{romName}.auto.state"
                : $"{romName}.*";

            var exactMatch = Directory.EnumerateFiles(mediaDirectoryPath, exactPattern, SearchOption.AllDirectories)
                .FirstOrDefault();
            if (exactMatch is not null) return exactMatch;

            var normalizedRomName = NormalizeTitle(romName);
            var normalizedMatch = Directory.EnumerateFiles(mediaDirectoryPath, "*", SearchOption.AllDirectories)
                .FirstOrDefault(file =>
                {
                    var filename = System.IO.Path.GetFileName(file);
                    var baseName = mediaDirectory.Equals("states", StringComparison.OrdinalIgnoreCase) &&
                                   filename.EndsWith(".auto.state", StringComparison.OrdinalIgnoreCase)
                        ? filename[..^".auto.state".Length]
                        : System.IO.Path.GetFileNameWithoutExtension(file);

                    return NormalizeTitle(baseName) == normalizedRomName;
                });

            if (normalizedMatch is not null) return normalizedMatch;
        }

        return null;
    }

    private static string NormalizeTitle(string title)
    {
        var result = new StringBuilder(title.Length);
        foreach (var character in title)
            if (char.IsLetterOrDigit(character))
                result.Append(char.ToLowerInvariant(character));

        return result.ToString();
    }
}
