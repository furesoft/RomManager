using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace RomManager.Hosting;

internal static class AppHost
{
    private static IHost? _host;

    public static IHost Host =>
        _host ?? throw new InvalidOperationException("The application host has not been initialized.");

    public static IServiceProvider Services => Host.Services;

    public static IConfiguration Configuration => Services.GetRequiredService<IConfiguration>();

    public static void Initialize(IHost host)
    {
        _host = host;
    }

    public static void Start()
    {
        Host.StartAsync().GetAwaiter().GetResult();
    }

    public static void Stop()
    {
        Host.StopAsync().GetAwaiter().GetResult();
        Host.Dispose();
        _host = null;
    }
}
