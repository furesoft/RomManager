using System;
using Avalonia;
using Avalonia.Controls;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RomManager.Configurations;
using RomManager.Core;
using RomManager.ViewModels;
using RomManager.Views;

namespace RomManager.Hosting;

public static class AppBuilderHostingExtensions
{
    public static AppBuilder UseMicrosoftHosting(this AppBuilder appBuilder, string[] args, Action<HostApplicationBuilder>? configureHost = null)
    {
        ArgumentNullException.ThrowIfNull(appBuilder);
        ArgumentNullException.ThrowIfNull(args);

        if (Design.IsDesignMode)
        {
            return appBuilder;
        }

        var hostBuilder = Host.CreateApplicationBuilder(args);
        hostBuilder.Services
            .AddOptions<PathsConfiguration>()
            .Bind(hostBuilder.Configuration.GetSection(PathsConfiguration.SectionName));

        hostBuilder.Services.AddSingleton<MainWindow>();
        hostBuilder.Services.AddSingleton<MainWindowViewModel>();
        hostBuilder.Services.AddSingleton<HomePageViewModel>();
        hostBuilder.Services.AddTransient<SettingsPageViewModel>();

        hostBuilder.Services.AddSingleton<IStartupInitializer, UpdateInitializer>();

        configureHost?.Invoke(hostBuilder);

        AppHost.Initialize(hostBuilder.Build());
        return appBuilder;
    }
}
