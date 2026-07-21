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
        if (!IsReachable(pathsConfiguration))
        {
            return false;
        }

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
        if (!IsReachable(pathsConfiguration))
        {
            return [];
        }

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
        {
            gameInfo = new GameInfo { Path = file, Name = System.IO.Path.GetFileNameWithoutExtension(file) };
        }

        return new Game
        {
            Info = gameInfo,
            Files = GetFiles(pathsConfiguration, file).ToArray()
        };
    }

    private IEnumerable<IHasFilename> GetFiles(PathsConfiguration pathsConfiguration, string romFilename)
    {
       yield return new RomFile { Filename = romFilename, SystemInfo = this};

       var name = System.IO.Path.GetFileNameWithoutExtension(romFilename);
       var coverPath = System.IO.Path.Combine(pathsConfiguration.BasePath, pathsConfiguration.Media, Path, "covers");
       if (!Directory.Exists(coverPath))
       {
           yield break;
       }

       var coverArt = Directory.EnumerateFiles(coverPath, $"{name}.*", SearchOption.AllDirectories).FirstOrDefault();
       if (coverArt is null)
       {
           var normalizedName = NormalizeTitle(name);
           coverArt = Directory.EnumerateFiles(coverPath, "*", SearchOption.AllDirectories)
               .FirstOrDefault(file => NormalizeTitle(System.IO.Path.GetFileNameWithoutExtension(file)) == normalizedName);
       }

       if (coverArt is not null) yield return new CoverArtImage { Filename = coverArt };
    }

    private static string NormalizeTitle(string title)
    {
        var result = new StringBuilder(title.Length);
        foreach (var character in title)
        {
            if (char.IsLetterOrDigit(character))
            {
                result.Append(char.ToLowerInvariant(character));
            }
        }

        return result.ToString();
    }
}
