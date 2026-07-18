using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using RomManager.Configurations;
using RomManager.Models;

namespace RomManager.Core;

public class LoadRomsInitializer(RomManager romManager) : StartupInitializer
{
    public override async Task InitializeAsync(IProgress<int> progress, CancellationToken cancellationToken)
    {
        progress.Report(-1);
        foreach (var system in romManager.Systems)
        {
            Text = $"Loading Files for {system.Name}...";
        }
    }
}