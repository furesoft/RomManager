using System;
using System.Linq;
using System.Threading.Tasks;
using Avalonia.Collections;
using Avalonia.Controls;
using Avalonia.Platform.Storage;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.Options;
using RomManager.Configurations;
using RomManager.Core;
using RomManager.Core.RegionDetection;
using RomManager.Models;

namespace RomManager.ViewModels;

public partial class LibraryPageViewModel : ObservableObject
{
    private readonly FilenameFilterBuilder _filenameFilterBuilder;
    [ObservableProperty] private AvaloniaList<SystemInfo>? _selectedSystems = [];
    [ObservableProperty] private AvaloniaList<Region?>? _selectedRegions = [];

    public LibraryPageViewModel(Core.RomManager romManager, FilenameFilterBuilder filenameFilterBuilder, IOptions<PathsConfiguration> pathsConfiguration)
    {
        _filenameFilterBuilder = filenameFilterBuilder;
        RomManager = romManager;

        AvailableSystems = romManager.Systems
            .Select(system => new
            {
                System = system,
                HasGames = system.HasGames(pathsConfiguration.Value)
            })
            .OrderByDescending(item => item.HasGames)
            .ThenBy(item => item.System.Name)
            .Select(item => (SystemInfo?)item.System)
            .Prepend(null)
            .ToArray();

        AvailableRegions = Enum.GetValues<Region>().Cast<Region?>().Prepend(null).ToArray();

        GamesView = new DataGridCollectionView(romManager.Games)
        {
            Filter = FilterGames
        };

        SelectedSystems!.CollectionChanged += (s, e) =>
        {
            GamesView.Refresh();
        };

        SelectedRegions!.CollectionChanged += (s, e) =>
        {
            GamesView.Refresh();
        };
    }

    public Core.RomManager RomManager { get; }

    public DataGridCollectionView GamesView { get; }

    public SystemInfo?[] AvailableSystems { get; }
    public Region?[] AvailableRegions { get; }

    private bool FilterGames(object obj)
    {
        if (obj is not Game game) return false;

        if (SelectedSystems is not null && SelectedSystems.Count > 0)
            if (game.Systems.All(s => !SelectedSystems.Contains(s)))
                return false;

        if (SelectedRegions is not null && SelectedRegions.Count > 0)
            if (game.Regions.All(r => !SelectedRegions.Contains(r)))
                return false;

        return true;
    }

    [RelayCommand]
    public async Task ImportRom()
    {
        var mainWindow = App.Current.ApplicationLifetime is Avalonia.Controls.ApplicationLifetimes.IClassicDesktopStyleApplicationLifetime desktop
            ? desktop.MainWindow
            : null;

        var topLevel = TopLevel.GetTopLevel(mainWindow);
        var result = await topLevel!.StorageProvider.OpenFilePickerAsync(new FilePickerOpenOptions()
        {
            AllowMultiple = false,
            Title = "Select ROM to Import",
            FileTypeFilter = _filenameFilterBuilder.GetFilter()
        });
    }
}
