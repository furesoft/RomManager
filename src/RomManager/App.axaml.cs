using System;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Avalonia.Threading;
using Microsoft.Extensions.DependencyInjection;
using PleasantUI.Core.Interfaces;
using PleasantUI.ToolKit.Controls;
using RomManager.Hosting;

namespace RomManager;

public partial class App : Application
{
    private const string ApplicationName = "Rom Manager";
    private static int _isCrashDialogShown;

    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this); // required
    }

    public override void OnFrameworkInitializationCompleted()
    {
        RegisterGlobalExceptionHandlers();
        AppHost.Start();

        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.Exit += OnDesktopExit;
            desktop.MainWindow = AppHost.Services.GetRequiredService<MainWindow>();
        }

        base.OnFrameworkInitializationCompleted();
    }

    private static void OnDesktopExit(object? sender, ControlledApplicationLifetimeExitEventArgs e)
    {
        AppHost.Stop();
    }

    private static void RegisterGlobalExceptionHandlers()
    {
        AppDomain.CurrentDomain.UnhandledException += OnCurrentDomainUnhandledException;
        TaskScheduler.UnobservedTaskException += OnTaskSchedulerUnobservedTaskException;
        Dispatcher.UIThread.UnhandledException += OnUiThreadUnhandledException;
    }

    private static void OnUiThreadUnhandledException(object? sender, DispatcherUnhandledExceptionEventArgs e)
    {
        e.Handled = true;
        _ = ShowCrashDialogAsync(e.Exception);
    }

    private static void OnTaskSchedulerUnobservedTaskException(object? sender, UnobservedTaskExceptionEventArgs e)
    {
        e.SetObserved();
        ShowCrashDialog(e.Exception);
    }

    private static void OnCurrentDomainUnhandledException(object? sender, UnhandledExceptionEventArgs e)
    {
        if (e.ExceptionObject is Exception exception)
        {
            if (Dispatcher.UIThread.CheckAccess())
            {
                ShowCrashDialogAsync(exception).GetAwaiter().GetResult();
                return;
            }

            Dispatcher.UIThread.InvokeAsync(() => ShowCrashDialogAsync(exception)).GetAwaiter().GetResult();
        }
    }

    private static void ShowCrashDialog(Exception exception)
    {
        if (Dispatcher.UIThread.CheckAccess())
        {
            _ = ShowCrashDialogAsync(exception);
            return;
        }

        Dispatcher.UIThread.Post(() => _ = ShowCrashDialogAsync(exception));
    }

    private static async Task ShowCrashDialogAsync(Exception exception)
    {
        if (Interlocked.CompareExchange(ref _isCrashDialogShown, 1, 0) != 0)
        {
            return;
        }

        Window? fallbackWindow = null;
        try
        {
            var desktop = Current?.ApplicationLifetime as IClassicDesktopStyleApplicationLifetime;
            var hostWindow = desktop?.MainWindow ?? desktop?.Windows.FirstOrDefault(window => window.IsVisible);
            if (hostWindow is null)
            {
                fallbackWindow = new Window
                {
                    Width = 1,
                    Height = 1,
                    Opacity = 0,
                    ShowInTaskbar = false,
                    CanResize = false
                };

                fallbackWindow.Show();
                hostWindow = fallbackWindow;
            }

            var dialog = CrashReportDialog.FromException(exception, ApplicationName, ResolveAppVersion());
            if (hostWindow is IPleasantWindow pleasantWindow)
            {
                await dialog.ShowAsync(pleasantWindow);
            }
            else
            {
                await dialog.ShowAsync(hostWindow);
            }
        }
        finally
        {
            fallbackWindow?.Close();
            Interlocked.Exchange(ref _isCrashDialogShown, 0);
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
}
