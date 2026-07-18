using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

namespace RomManager.Core;

public class LoadGamesBackgroundService(RomManager romManager) : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        await Parallel.ForEachAsync(romManager.Games, stoppingToken, async (game, token) =>
        {
            game.Load();
            await Task.Yield();
        });
    }
}