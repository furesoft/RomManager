using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace RomManager.Core;

public class LoadGamesBackgroundService(RomManager romManager, ILogger<LoadGamesBackgroundService> logger) : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var gameCount = romManager.Games.Count;
        if (gameCount == 0)
        {
            logger.LogInformation("Background game loading skipped because no games are available.");
            return;
        }

        logger.LogInformation("Background game loading started for {GameCount} games.", gameCount);

        var loadedCount = 0;
        var startedAt = DateTimeOffset.UtcNow;

        try
        {
            await Parallel.ForEachAsync(romManager.Games, stoppingToken, async (game, token) =>
            {
                try
                {
                    game.Load();
                    var current = Interlocked.Increment(ref loadedCount);
                    if (current % 100 == 0 || current == gameCount)
                        logger.LogInformation("Background game loading progress: {LoadedCount}/{GameCount}.", current,
                            gameCount);
                }
                catch (Exception ex)
                {
                    var gameName = game.Info?.Name ?? game.Name;
                    logger.LogError(ex, "Background game loading failed for game '{GameName}'.", gameName);
                    throw;
                }

                await Task.Yield();
            });
        }
        catch (OperationCanceledException) when (stoppingToken.IsCancellationRequested)
        {
            logger.LogInformation("Background game loading was cancelled after loading {LoadedCount}/{GameCount} games.",
                loadedCount, gameCount);
            throw;
        }

        var durationMs = (DateTimeOffset.UtcNow - startedAt).TotalMilliseconds;
        logger.LogInformation(
            "Background game loading finished. Loaded {LoadedCount}/{GameCount} games in {DurationMs:0} ms.",
            loadedCount, gameCount, durationMs);
    }
}
