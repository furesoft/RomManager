using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Extensions.Options;
using RomManager.Configurations;
using RomManager.Models;

namespace RomManager.Core;

public class RomManager
{
    public RomManager(IEnumerable<SystemInfo> systems, IOptions<PathsConfiguration> pathsConfiguration)
    {
        Systems = systems;

        Games = Systems.SelectMany(system =>
        {
            if (!system.IsReachable(pathsConfiguration.Value)) return [];
            system.GameList = GameList.ReadFromFile(system);
            system.GameList.GamesByFilename = system.GameList.Games
                .ToDictionary(g => Path.GetFileName(g.Path), g => g);

            return system.GetGames(pathsConfiguration.Value);
        }).ToList();
    }

    public IEnumerable<SystemInfo> Systems { get; }

    public IReadOnlyList<Game> Games { get; }
}
