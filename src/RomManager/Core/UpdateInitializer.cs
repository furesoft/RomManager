using System;
using System.Threading;
using System.Threading.Tasks;
using Velopack;
using Velopack.Sources;

namespace RomManager.Core;

public class UpdateInitializer : StartupInitializer
{
    public override async Task InitializeAsync(IProgress<int> progress, CancellationToken cancellationToken)
    {
        Text = "Checking for updates...";
        var mgr = new UpdateManager(new GithubSource("https://github.com/furesoft/RomManager", null, false));

        if (!mgr.IsInstalled)
        {
            return;
        }

        var newVersion = await mgr.CheckForUpdatesAsync();
        if (newVersion == null)
        {
            return;
        }

        await mgr.DownloadUpdatesAsync(newVersion, progress.Report, cancellationToken);

        mgr.ApplyUpdatesAndRestart(newVersion);
    }
}