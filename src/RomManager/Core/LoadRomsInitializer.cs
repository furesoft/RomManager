using System;
using System.Threading;
using System.Threading.Tasks;

namespace RomManager.Core;

public class LoadRomsInitializer(RomManager romManager) : StartupInitializer
{
    public override async Task InitializeAsync(IProgress<int> progress, CancellationToken cancellationToken)
    {
        progress.Report(-1);
        foreach (var system in romManager.Systems) Text = $"Loading Files for {system.Name}...";
    }
}
