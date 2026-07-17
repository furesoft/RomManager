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

        hostBuilder.Services.AddTransient<N64>();
        hostBuilder.Services.AddTransient<Adam>();
        hostBuilder.Services.AddTransient<Amiga>();
        hostBuilder.Services.AddTransient<Amiga1200>();
        hostBuilder.Services.AddTransient<Amiga600>();
        hostBuilder.Services.AddTransient<Amigacd32>();
        hostBuilder.Services.AddTransient<Amstradcpc>();
        hostBuilder.Services.AddTransient<Apple2>();
        hostBuilder.Services.AddTransient<Apple2gs>();
        hostBuilder.Services.AddTransient<Arcade>();
        hostBuilder.Services.AddTransient<Arcadia>();
        hostBuilder.Services.AddTransient<Archimedes>();
        hostBuilder.Services.AddTransient<Arduboy>();
        hostBuilder.Services.AddTransient<Astrocde>();
        hostBuilder.Services.AddTransient<Atari>();
        hostBuilder.Services.AddTransient<Atari2600>();
        hostBuilder.Services.AddTransient<Atari5200>();
        hostBuilder.Services.AddTransient<Atari7800>();
        hostBuilder.Services.AddTransient<Atari800>();
        hostBuilder.Services.AddTransient<Atarist>();
        hostBuilder.Services.AddTransient<Atarixe>();
        hostBuilder.Services.AddTransient<Atomiswave>();
        hostBuilder.Services.AddTransient<Bbcmicro>();
        hostBuilder.Services.AddTransient<C64>();
        hostBuilder.Services.AddTransient<Cdimono1>();
        hostBuilder.Services.AddTransient<Chailove>();
        hostBuilder.Services.AddTransient<Channelf>();
        hostBuilder.Services.AddTransient<Col>();
        hostBuilder.Services.AddTransient<Colecovision>();
        hostBuilder.Services.AddTransient<Consolearcade>();
        hostBuilder.Services.AddTransient<Cpc>();
        hostBuilder.Services.AddTransient<Cps1>();
        hostBuilder.Services.AddTransient<Cps2>();
        hostBuilder.Services.AddTransient<Cps3>();
        hostBuilder.Services.AddTransient<Crvision>();
        hostBuilder.Services.AddTransient<Daphne>();
        hostBuilder.Services.AddTransient<Doom>();
        hostBuilder.Services.AddTransient<Dos>();
        hostBuilder.Services.AddTransient<Dreamcast>();
        hostBuilder.Services.AddTransient<Easyrpg>();
        hostBuilder.Services.AddTransient<Electron>();
        hostBuilder.Services.AddTransient<Emulators>();
        hostBuilder.Services.AddTransient<Famicom>();
        hostBuilder.Services.AddTransient<Fba>();
        hostBuilder.Services.AddTransient<Fbneo>();
        hostBuilder.Services.AddTransient<Fds>();
        hostBuilder.Services.AddTransient<Flash>();
        hostBuilder.Services.AddTransient<Fm7>();
        hostBuilder.Services.AddTransient<Fmtowns>();
        hostBuilder.Services.AddTransient<Gamate>();
        hostBuilder.Services.AddTransient<Gameandwatch>();
        hostBuilder.Services.AddTransient<Gamecom>();
        hostBuilder.Services.AddTransient<Gamegear>();
        hostBuilder.Services.AddTransient<Gb>();
        hostBuilder.Services.AddTransient<Gba>();
        hostBuilder.Services.AddTransient<Gbc>();
        hostBuilder.Services.AddTransient<Gc>();
        hostBuilder.Services.AddTransient<Genesis>();
        hostBuilder.Services.AddTransient<Gmaster>();
        hostBuilder.Services.AddTransient<Gp>();
        hostBuilder.Services.AddTransient<Gw>();
        hostBuilder.Services.AddTransient<Gx4000>();
        hostBuilder.Services.AddTransient<Intellivision>();
        hostBuilder.Services.AddTransient<Itv>();
        hostBuilder.Services.AddTransient<J2me>();
        hostBuilder.Services.AddTransient<Laserdisc>();
        hostBuilder.Services.AddTransient<Lcdgames>();
        hostBuilder.Services.AddTransient<Lowresnx>();
        hostBuilder.Services.AddTransient<Lutris>();
        hostBuilder.Services.AddTransient<Lutro>();
        hostBuilder.Services.AddTransient<Macintosh>();
        hostBuilder.Services.AddTransient<Mame>();
        hostBuilder.Services.AddTransient<Mastersystem>();
        hostBuilder.Services.AddTransient<Megacd>();
        hostBuilder.Services.AddTransient<Megacdjp>();
        hostBuilder.Services.AddTransient<Megadrive>();
        hostBuilder.Services.AddTransient<Megaduck>();
        hostBuilder.Services.AddTransient<Mess>();
        hostBuilder.Services.AddTransient<Model2>();
        hostBuilder.Services.AddTransient<Moto>();
        hostBuilder.Services.AddTransient<Msu1>();
        hostBuilder.Services.AddTransient<Msumd>();
        hostBuilder.Services.AddTransient<Msx>();
        hostBuilder.Services.AddTransient<N64>();
        hostBuilder.Services.AddTransient<N64dd>();
        hostBuilder.Services.AddTransient<Naomigd>();
        hostBuilder.Services.AddTransient<Nds>();
        hostBuilder.Services.AddTransient<Neogeo>();
        hostBuilder.Services.AddTransient<Neogeocd>();
        hostBuilder.Services.AddTransient<Nes>();
        hostBuilder.Services.AddTransient<Odyssey2>();
        hostBuilder.Services.AddTransient<Openbor>();
        hostBuilder.Services.AddTransient<Palm>();
        hostBuilder.Services.AddTransient<Pc>();
        hostBuilder.Services.AddTransient<Pc88>();
        hostBuilder.Services.AddTransient<Pc98>();
        hostBuilder.Services.AddTransient<Pcarcade>();
        hostBuilder.Services.AddTransient<Pcengine>();
        hostBuilder.Services.AddTransient<Pcenginecd>();
        hostBuilder.Services.AddTransient<Pcfx>();
        hostBuilder.Services.AddTransient<Pico8>();
        hostBuilder.Services.AddTransient<Plus4>();
        hostBuilder.Services.AddTransient<Pokemini>();
        hostBuilder.Services.AddTransient<PortMaster>();
        hostBuilder.Services.AddTransient<Ps1>();
        hostBuilder.Services.AddTransient<Ps2>();
        hostBuilder.Services.AddTransient<Psp>();
        hostBuilder.Services.AddTransient<Psx>();
        hostBuilder.Services.AddTransient<Quake>();
        hostBuilder.Services.AddTransient<SatellaView>();
        hostBuilder.Services.AddTransient<Scummvm>();
        hostBuilder.Services.AddTransient<Scv>();
        hostBuilder.Services.AddTransient<Sega32x>();
        hostBuilder.Services.AddTransient<Sega32xjp>();
        hostBuilder.Services.AddTransient<Sega32xna>();
        hostBuilder.Services.AddTransient<Segacd>();
        hostBuilder.Services.AddTransient<Sfc>();
        hostBuilder.Services.AddTransient<Sg1000>();
        hostBuilder.Services.AddTransient<Sgb>();
        hostBuilder.Services.AddTransient<Sgfx>();
        hostBuilder.Services.AddTransient<Snes>();
        hostBuilder.Services.AddTransient<Snesna>();
        hostBuilder.Services.AddTransient<Solarus>();
        hostBuilder.Services.AddTransient<Spectravideo>();
        hostBuilder.Services.AddTransient<Stv>();
        hostBuilder.Services.AddTransient<Sufami>();
        hostBuilder.Services.AddTransient<Supergrafx>();
        hostBuilder.Services.AddTransient<Supervision>();
        hostBuilder.Services.AddTransient<Supracan>();
        hostBuilder.Services.AddTransient<Switch>();
        hostBuilder.Services.AddTransient<System3do>();
        hostBuilder.Services.AddTransient<Tg16>();
        hostBuilder.Services.AddTransient<Tgcd>();
        hostBuilder.Services.AddTransient<Ti99>();
        hostBuilder.Services.AddTransient<Tic>();
        hostBuilder.Services.AddTransient<Tic80>();
        hostBuilder.Services.AddTransient<To8>();
        hostBuilder.Services.AddTransient<Triforce>();
        hostBuilder.Services.AddTransient<Uzebox>();
        hostBuilder.Services.AddTransient<Vb>();
        hostBuilder.Services.AddTransient<Vdp>();
        hostBuilder.Services.AddTransient<Vectrex>();
        hostBuilder.Services.AddTransient<Vic20>();
        hostBuilder.Services.AddTransient<Videopac>();
        hostBuilder.Services.AddTransient<Vsmile>();
        hostBuilder.Services.AddTransient<Wasm4>();
        hostBuilder.Services.AddTransient<Wii>();
        hostBuilder.Services.AddTransient<Wiiu>();
        hostBuilder.Services.AddTransient<RomManager.Systems.Windows>();
        hostBuilder.Services.AddTransient<Windows3x>();
        hostBuilder.Services.AddTransient<Windows9x>();
        hostBuilder.Services.AddTransient<Wonderswan>();
        hostBuilder.Services.AddTransient<Wonderswancolor>();
        hostBuilder.Services.AddTransient<Ws>();
        hostBuilder.Services.AddTransient<Wsc>();
        hostBuilder.Services.AddTransient<X1>();
        hostBuilder.Services.AddTransient<X68000>();
        hostBuilder.Services.AddTransient<Xbox>();
        hostBuilder.Services.AddTransient<Zx81>();
        hostBuilder.Services.AddTransient<Zxspectrum>();        

        hostBuilder.Services.AddSingleton<IStartupInitializer, UpdateInitializer>();

        configureHost?.Invoke(hostBuilder);

        AppHost.Initialize(hostBuilder.Build());
        return appBuilder;
    }
}
