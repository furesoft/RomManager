using System;
using System.IO;
using System.Linq;
using System.Reflection;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Extensions.Options;
using RomManager.Configurations;

namespace RomManager.ViewModels;

public partial class HomePageViewModel : ObservableObject
{
    public HomePageViewModel(IOptions<PathsConfiguration> pathsOptions)
    {
        PathsConfiguration = pathsOptions.Value;

        AppVersion = ResolveAppVersion();
        BasePathSummary = BuildPathSummary(PathsConfiguration.BasePath, includeFileCount: false);
        RomsSummary = BuildPathSummary(PathsConfiguration.Roms);
        SaveGamesSummary = BuildPathSummary(PathsConfiguration.SaveGames);

        ConfiguredFolderCount = CountConfiguredFolders();
        ReachableFolderCount = CountReachableFolders();
        KnownFileCount = SumKnownFileCounts(RomsSummary, SaveGamesSummary);

        SetupCoverageText = $"{ReachableFolderCount}/3 Ordner erreichbar";
        ConfiguredFolderText = $"{ConfiguredFolderCount}/3 Pfade konfiguriert";
        KnownFileCountText = $"{KnownFileCount:N0} Dateien gefunden";
        LibraryStateText = BuildLibraryStateText();
    }

    public PathsConfiguration PathsConfiguration { get; }

    public string AppVersion { get; }

    public string SetupCoverageText { get; }

    public string ConfiguredFolderText { get; }

    public string KnownFileCountText { get; }

    public string LibraryStateText { get; }

    public int ConfiguredFolderCount { get; }

    public int ReachableFolderCount { get; }

    public long KnownFileCount { get; }

    public FolderSummary BasePathSummary { get; }

    public FolderSummary RomsSummary { get; }

    public FolderSummary SaveGamesSummary { get; }

    private int CountConfiguredFolders()
    {
        return CountNonEmpty(PathsConfiguration.BasePath, PathsConfiguration.Roms, PathsConfiguration.SaveGames);
    }

    private int CountReachableFolders()
    {
        return CountExisting(PathsConfiguration.BasePath, PathsConfiguration.Roms, PathsConfiguration.SaveGames);
    }

    private static int CountNonEmpty(params string?[] paths)
    {
        return paths.Count(path => !string.IsNullOrWhiteSpace(path));
    }

    private static int CountExisting(params string?[] paths)
    {
        return paths.Count(path => !string.IsNullOrWhiteSpace(path) && Directory.Exists(path));
    }

    private static long SumKnownFileCounts(params FolderSummary[] summaries)
    {
        return summaries.Sum(summary => summary.FileCount ?? 0);
    }

    private string BuildLibraryStateText()
    {
        if (ReachableFolderCount == 3)
        {
            return "Alle Pfade erreichbar";
        }

        if (ReachableFolderCount == 0)
        {
            return "Noch keine Pfade erreichbar";
        }

        return "Teilweise erreichbar";
    }

    private FolderSummary BuildPathSummary(string? path, bool includeFileCount = true)
    {
        path = Path.Combine(PathsConfiguration.BasePath, path);
        if (string.IsNullOrWhiteSpace(path))
        {
            return new FolderSummary("Nicht konfiguriert", "Noch nicht eingerichtet", "Keine Dateien");
        }

        if (!Directory.Exists(path))
        {
            return new FolderSummary(path, "Ordner fehlt", "0 Dateien");
        }

        if (!includeFileCount)
        {
            return new FolderSummary(path, "Bereit", "—");
        }

        var fileCountResult = TryCountFiles(path);
        if (fileCountResult.Count is null)
        {
            return new FolderSummary(path, fileCountResult.StatusText, "Nicht lesbar");
        }

        return new FolderSummary(path, "Bereit", $"{fileCountResult.Count:N0} Dateien")
        {
            FileCount = fileCountResult.Count
        };
    }

    private static FileCountResult TryCountFiles(string path)
    {
        try
        {
            var count = Directory.EnumerateFiles(path, "*", SearchOption.AllDirectories).LongCount();
            return new FileCountResult(count, "Bereit");
        }
        catch (UnauthorizedAccessException)
        {
            return new FileCountResult(null, "Zugriff verweigert");
        }
        catch (IOException)
        {
            return new FileCountResult(null, "Dateisystemfehler");
        }
    }

    private static string ResolveAppVersion()
    {
        var assembly = Assembly.GetEntryAssembly() ?? Assembly.GetExecutingAssembly();
        var informationalVersion = assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion;
        if (!string.IsNullOrWhiteSpace(informationalVersion))
        {
            return informationalVersion;
        }

        return assembly.GetName().Version?.ToString(3) ?? "Unbekannt";
    }

    public sealed record FolderSummary(string PathText, string StatusText, string FileCountText)
    {
        public long? FileCount { get; init; }
    }

    private sealed record FileCountResult(long? Count, string StatusText);
}
