using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Options;
using RomManager.Configurations;
using RomManager.Models;

namespace RomManager.Core;

public class RomManager
{
    public IEnumerable<SystemInfo> Systems { get; }

    public IReadOnlyList<Game> Games { get; }
    public RomManager(IEnumerable<SystemInfo> systems, IOptions<PathsConfiguration> pathsConfiguration)
    {
        Systems = systems;

        Games = Systems.SelectMany(system =>
        {
            if (!system.IsReachable(pathsConfiguration.Value))
            {
                return [];
            }
            system.GameList = GameList.ReadFromFile(system);
            system.GameList.GamesByFilename = system.GameList.Games
                .ToDictionary(g => System.IO.Path.GetFileName(g.Path), g => g);

            return system.GetGames(pathsConfiguration.Value);
        }).ToList();
    }
}
