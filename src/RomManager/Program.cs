using System;
using Avalonia;
using RomManager.Hosting;

namespace RomManager;

internal sealed class Program
{
    // Initialization code. Don't use any Avalonia, third-party APIs or any
    // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
    // yet and stuff might break.
    [STAThread]
    public static void Main(string[] args) => BuildAvaloniaApp(args)
        .StartWithClassicDesktopLifetime(args);

    // Avalonia configuration, don't remove; also used by visual designer.
    public static AppBuilder BuildAvaloniaApp(string[]? args = null) => AppBuilder
        .Configure<App>()
        .UseMicrosoftHosting(args ?? Array.Empty<string>())
        .UsePlatformDetect()
        .WithInterFont()
        .LogToTrace();
}
