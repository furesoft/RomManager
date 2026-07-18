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

            return system.GetGames(pathsConfiguration.Value);
        }).ToList();
    }
}