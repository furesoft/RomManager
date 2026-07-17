using System.Collections.Generic;
using System.IO;
using System.Linq;
using RomManager.Configurations;
using RomManager.Models.FileTypes;

namespace RomManager.Models;

public abstract class SystemInfo
{
    public abstract string Name { get; }
    public abstract string Path { get; }
    public abstract string[] Extensions { get; }

    public abstract string? IconName { get; }

    public override string ToString()
    {
        return Name;
    }

    public bool IsReachable(PathsConfiguration pathsConfiguration)
    {
        var folderPath = System.IO.Path.Combine(pathsConfiguration.BasePath, Path);
        return Directory.Exists(folderPath);
    }

    public List<Game> GetGames(PathsConfiguration pathsConfiguration)
    {
        var folderPath = System.IO.Path.Combine(pathsConfiguration.BasePath, pathsConfiguration.Roms, Path);
        var roms = Directory.EnumerateFiles(folderPath, "*", SearchOption.AllDirectories)
            .Where(file => Extensions.Contains(System.IO.Path.GetExtension(file).ToLower()));

        var games =
            from file in roms
            select new Game
        {
            Name = System.IO.Path.GetFileNameWithoutExtension(file),
            Files = [
                new RomFile
                {
                    Filename = file
                }
            ]
        };

        return games.ToList();
    }
}