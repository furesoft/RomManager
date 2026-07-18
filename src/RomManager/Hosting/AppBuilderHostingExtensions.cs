using System;
using Avalonia;
using Avalonia.Controls;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RomManager.Configurations;
using RomManager.Core;
using RomManager.Models;
using RomManager.Systems;
using RomManager.ViewModels;

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
        hostBuilder.Services.AddTransient<LibraryPageViewModel>();
        hostBuilder.Services.AddTransient<SettingsPageViewModel>();

        hostBuilder.Services.AddSingleton<Core.RomManager>();

        AddSystemInfos(hostBuilder);

        hostBuilder.Services.AddSingleton<StartupInitializer, UpdateInitializer>();
        hostBuilder.Services.AddSingleton<StartupInitializer, LoadRomsInitializer>();

        hostBuilder.Services.AddHostedService<LoadGamesBackgroundService>();

        configureHost?.Invoke(hostBuilder);

        AppHost.Initialize(hostBuilder.Build());
        return appBuilder;
    }

    private static void AddSystemInfos(HostApplicationBuilder hostBuilder)
    {
        hostBuilder.Services.AddTransient<SystemInfo, N64>();
        hostBuilder.Services.AddTransient<SystemInfo, Adam>();
        hostBuilder.Services.AddTransient<SystemInfo, Amiga>();
        hostBuilder.Services.AddTransient<SystemInfo, Amiga1200>();
        hostBuilder.Services.AddTransient<SystemInfo, Amiga600>();
        hostBuilder.Services.AddTransient<SystemInfo, Amigacd32>();
        hostBuilder.Services.AddTransient<SystemInfo, Amstradcpc>();
        hostBuilder.Services.AddTransient<SystemInfo, Apple2>();
        hostBuilder.Services.AddTransient<SystemInfo, Apple2gs>();
        hostBuilder.Services.AddTransient<SystemInfo, Arcade>();
        hostBuilder.Services.AddTransient<SystemInfo, Arcadia>();
        hostBuilder.Services.AddTransient<SystemInfo, Archimedes>();
        hostBuilder.Services.AddTransient<SystemInfo, Arduboy>();
        hostBuilder.Services.AddTransient<SystemInfo, Astrocde>();
        hostBuilder.Services.AddTransient<SystemInfo, Atari>();
        hostBuilder.Services.AddTransient<SystemInfo, Atari2600>();
        hostBuilder.Services.AddTransient<SystemInfo, Atari5200>();
        hostBuilder.Services.AddTransient<SystemInfo, Atari7800>();
        hostBuilder.Services.AddTransient<SystemInfo, Atari800>();
        hostBuilder.Services.AddTransient<SystemInfo, Atarist>();
        hostBuilder.Services.AddTransient<SystemInfo, Atarixe>();
        hostBuilder.Services.AddTransient<SystemInfo, Atomiswave>();
        hostBuilder.Services.AddTransient<SystemInfo, Bbcmicro>();
        hostBuilder.Services.AddTransient<SystemInfo, C64>();
        hostBuilder.Services.AddTransient<SystemInfo, Cdimono1>();
        hostBuilder.Services.AddTransient<SystemInfo, Chailove>();
        hostBuilder.Services.AddTransient<SystemInfo, Channelf>();
        hostBuilder.Services.AddTransient<SystemInfo, Col>();
        hostBuilder.Services.AddTransient<SystemInfo, Colecovision>();
        hostBuilder.Services.AddTransient<SystemInfo, Consolearcade>();
        hostBuilder.Services.AddTransient<SystemInfo, Cpc>();
        hostBuilder.Services.AddTransient<SystemInfo, Cps1>();
        hostBuilder.Services.AddTransient<SystemInfo, Cps2>();
        hostBuilder.Services.AddTransient<SystemInfo, Cps3>();
        hostBuilder.Services.AddTransient<SystemInfo, Crvision>();
        hostBuilder.Services.AddTransient<SystemInfo, Daphne>();
        hostBuilder.Services.AddTransient<SystemInfo, Doom>();
        hostBuilder.Services.AddTransient<SystemInfo, Dos>();
        hostBuilder.Services.AddTransient<SystemInfo, Dreamcast>();
        hostBuilder.Services.AddTransient<SystemInfo, Easyrpg>();
        hostBuilder.Services.AddTransient<SystemInfo, Electron>();
        hostBuilder.Services.AddTransient<SystemInfo, Emulators>();
        hostBuilder.Services.AddTransient<SystemInfo, Famicom>();
        hostBuilder.Services.AddTransient<SystemInfo, Fba>();
        hostBuilder.Services.AddTransient<SystemInfo, Fbneo>();
        hostBuilder.Services.AddTransient<SystemInfo, Fds>();
        hostBuilder.Services.AddTransient<SystemInfo, Flash>();
        hostBuilder.Services.AddTransient<SystemInfo, Fm7>();
        hostBuilder.Services.AddTransient<SystemInfo, Fmtowns>();
        hostBuilder.Services.AddTransient<SystemInfo, Gamate>();
        hostBuilder.Services.AddTransient<SystemInfo, Gameandwatch>();
        hostBuilder.Services.AddTransient<SystemInfo, Gamecom>();
        hostBuilder.Services.AddTransient<SystemInfo, Gamegear>();
        hostBuilder.Services.AddTransient<SystemInfo, Gb>();
        hostBuilder.Services.AddTransient<SystemInfo, Gba>();
        hostBuilder.Services.AddTransient<SystemInfo, Gbc>();
        hostBuilder.Services.AddTransient<SystemInfo, Gc>();
        hostBuilder.Services.AddTransient<SystemInfo, Genesis>();
        hostBuilder.Services.AddTransient<SystemInfo, Gmaster>();
        hostBuilder.Services.AddTransient<SystemInfo, Gp>();
        hostBuilder.Services.AddTransient<SystemInfo, Gw>();
        hostBuilder.Services.AddTransient<SystemInfo, Gx4000>();
        hostBuilder.Services.AddTransient<SystemInfo, Intellivision>();
        hostBuilder.Services.AddTransient<SystemInfo, Itv>();
        hostBuilder.Services.AddTransient<SystemInfo, J2me>();
        hostBuilder.Services.AddTransient<SystemInfo, Laserdisc>();
        hostBuilder.Services.AddTransient<SystemInfo, Lcdgames>();
        hostBuilder.Services.AddTransient<SystemInfo, Lowresnx>();
        hostBuilder.Services.AddTransient<SystemInfo, Lutris>();
        hostBuilder.Services.AddTransient<SystemInfo, Lutro>();
        hostBuilder.Services.AddTransient<SystemInfo, Macintosh>();
        hostBuilder.Services.AddTransient<SystemInfo, Mame>();
        hostBuilder.Services.AddTransient<SystemInfo, Mastersystem>();
        hostBuilder.Services.AddTransient<SystemInfo, Megacd>();
        hostBuilder.Services.AddTransient<SystemInfo, Megacdjp>();
        hostBuilder.Services.AddTransient<SystemInfo, Megadrive>();
        hostBuilder.Services.AddTransient<SystemInfo, Megaduck>();
        hostBuilder.Services.AddTransient<SystemInfo, Mess>();
        hostBuilder.Services.AddTransient<SystemInfo, Model2>();
        hostBuilder.Services.AddTransient<SystemInfo, Moto>();
        hostBuilder.Services.AddTransient<SystemInfo, Msu1>();
        hostBuilder.Services.AddTransient<SystemInfo, Msumd>();
        hostBuilder.Services.AddTransient<SystemInfo, Msx>();
        hostBuilder.Services.AddTransient<SystemInfo, N64dd>();
        hostBuilder.Services.AddTransient<SystemInfo, Naomigd>();
        hostBuilder.Services.AddTransient<SystemInfo, Nds>();
        hostBuilder.Services.AddTransient<SystemInfo, Neogeo>();
        hostBuilder.Services.AddTransient<SystemInfo, Neogeocd>();
        hostBuilder.Services.AddTransient<SystemInfo, Nes>();
        hostBuilder.Services.AddTransient<SystemInfo, Odyssey2>();
        hostBuilder.Services.AddTransient<SystemInfo, Openbor>();
        hostBuilder.Services.AddTransient<SystemInfo, Palm>();
        hostBuilder.Services.AddTransient<SystemInfo, Pc>();
        hostBuilder.Services.AddTransient<SystemInfo, Pc88>();
        hostBuilder.Services.AddTransient<SystemInfo, Pc98>();
        hostBuilder.Services.AddTransient<SystemInfo, Pcarcade>();
        hostBuilder.Services.AddTransient<SystemInfo, Pcengine>();
        hostBuilder.Services.AddTransient<SystemInfo, Pcenginecd>();
        hostBuilder.Services.AddTransient<SystemInfo, Pcfx>();
        hostBuilder.Services.AddTransient<SystemInfo, Pico8>();
        hostBuilder.Services.AddTransient<SystemInfo, Plus4>();
        hostBuilder.Services.AddTransient<SystemInfo, Pokemini>();
        hostBuilder.Services.AddTransient<SystemInfo, PortMaster>();
        hostBuilder.Services.AddTransient<SystemInfo, Ps1>();
        hostBuilder.Services.AddTransient<SystemInfo, Ps2>();
        hostBuilder.Services.AddTransient<SystemInfo, Psp>();
        hostBuilder.Services.AddTransient<SystemInfo, Psx>();
        hostBuilder.Services.AddTransient<SystemInfo, Quake>();
        hostBuilder.Services.AddTransient<SystemInfo, SatellaView>();
        hostBuilder.Services.AddTransient<SystemInfo, Scummvm>();
        hostBuilder.Services.AddTransient<SystemInfo, Scv>();
        hostBuilder.Services.AddTransient<SystemInfo, Sega32x>();
        hostBuilder.Services.AddTransient<SystemInfo, Sega32xjp>();
        hostBuilder.Services.AddTransient<SystemInfo, Sega32xna>();
        hostBuilder.Services.AddTransient<SystemInfo, Segacd>();
        hostBuilder.Services.AddTransient<SystemInfo, Sfc>();
        hostBuilder.Services.AddTransient<SystemInfo, Sg1000>();
        hostBuilder.Services.AddTransient<SystemInfo, Sgb>();
        hostBuilder.Services.AddTransient<SystemInfo, Sgfx>();
        hostBuilder.Services.AddTransient<SystemInfo, Snes>();
        hostBuilder.Services.AddTransient<SystemInfo, Snesna>();
        hostBuilder.Services.AddTransient<SystemInfo, Solarus>();
        hostBuilder.Services.AddTransient<SystemInfo, Spectravideo>();
        hostBuilder.Services.AddTransient<SystemInfo, Stv>();
        hostBuilder.Services.AddTransient<SystemInfo, Sufami>();
        hostBuilder.Services.AddTransient<SystemInfo, Supergrafx>();
        hostBuilder.Services.AddTransient<SystemInfo, Supervision>();
        hostBuilder.Services.AddTransient<SystemInfo, Supracan>();
        hostBuilder.Services.AddTransient<SystemInfo, Switch>();
        hostBuilder.Services.AddTransient<SystemInfo, System3do>();
        hostBuilder.Services.AddTransient<SystemInfo, Tg16>();
        hostBuilder.Services.AddTransient<SystemInfo, Tgcd>();
        hostBuilder.Services.AddTransient<SystemInfo, Ti99>();
        hostBuilder.Services.AddTransient<SystemInfo, Tic>();
        hostBuilder.Services.AddTransient<SystemInfo, Tic80>();
        hostBuilder.Services.AddTransient<SystemInfo, To8>();
        hostBuilder.Services.AddTransient<SystemInfo, Triforce>();
        hostBuilder.Services.AddTransient<SystemInfo, Uzebox>();
        hostBuilder.Services.AddTransient<SystemInfo, Vb>();
        hostBuilder.Services.AddTransient<SystemInfo, Vdp>();
        hostBuilder.Services.AddTransient<SystemInfo, Vectrex>();
        hostBuilder.Services.AddTransient<SystemInfo, Vic20>();
        hostBuilder.Services.AddTransient<SystemInfo, Videopac>();
        hostBuilder.Services.AddTransient<SystemInfo, Vsmile>();
        hostBuilder.Services.AddTransient<SystemInfo, Wasm4>();
        hostBuilder.Services.AddTransient<SystemInfo, Wii>();
        hostBuilder.Services.AddTransient<SystemInfo, Wiiu>();
        hostBuilder.Services.AddTransient<SystemInfo, RomManager.Systems.Windows>();
        hostBuilder.Services.AddTransient<SystemInfo, Windows3x>();
        hostBuilder.Services.AddTransient<SystemInfo, Windows9x>();
        hostBuilder.Services.AddTransient<SystemInfo, Wonderswan>();
        hostBuilder.Services.AddTransient<SystemInfo, Wonderswancolor>();
        hostBuilder.Services.AddTransient<SystemInfo, Ws>();
        hostBuilder.Services.AddTransient<SystemInfo, Wsc>();
        hostBuilder.Services.AddTransient<SystemInfo, X1>();
        hostBuilder.Services.AddTransient<SystemInfo, X68000>();
        hostBuilder.Services.AddTransient<SystemInfo, Xbox>();
        hostBuilder.Services.AddTransient<SystemInfo, Zx81>();
        hostBuilder.Services.AddTransient<SystemInfo, Zxspectrum>();
    }
}
