using System;
using System.Collections.ObjectModel;
using System.Linq;
using Avalonia.Collections;
using CommunityToolkit.Mvvm.ComponentModel;
using RomManager.Core.RegionDetection;
using RomManager.Models;

namespace RomManager.ViewModels;

public partial class LibraryPageViewModel : ObservableObject
{
    [ObservableProperty] private Region? _selectedRegion;

    [ObservableProperty] private SystemInfo? _selectedSystem;

    public LibraryPageViewModel(Core.RomManager romManager)
    {
        RomManager = romManager;

        AvailableSystems = romManager.Systems.Prepend(null).ToArray();
        AvailableRegions = Enum.GetValues<Region>().Cast<Region?>().Prepend(null).ToArray();

        GamesView = new DataGridCollectionView(romManager.Games)
        {
            Filter = FilterGames
        };
    }

    public Core.RomManager RomManager { get; }

    public DataGridCollectionView GamesView { get; }

    public SystemInfo?[] AvailableSystems { get; }
    public Region?[] AvailableRegions { get; }

    partial void OnSelectedSystemChanged(SystemInfo? value)
    {
        GamesView.Refresh();
    }

    partial void OnSelectedRegionChanged(Region? value)
    {
        GamesView.Refresh();
    }

    private bool FilterGames(object obj)
    {
        if (obj is not Game game) return false;

        if (SelectedSystem is not null)
            if (game.Systems.All(s => s.Name != SelectedSystem.Name))
                return false;

        if (SelectedRegion is not null)
            if (game.Regions.All(r => r != SelectedRegion))
                return false;

        return true;
    }
}