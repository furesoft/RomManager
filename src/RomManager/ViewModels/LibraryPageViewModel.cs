using System;
using System.Collections.Specialized;
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
    private readonly INotifyCollectionChanged? _gamesCollectionNotifier;
    [ObservableProperty] private AvaloniaList<SystemInfo>? _selectedSystems = [];
    [ObservableProperty] private AvaloniaList<Region?>? _selectedRegions = [];
    [ObservableProperty] private bool _favoritesOnly;
    [ObservableProperty] private int _currentPage = 1;
    [ObservableProperty] private int _pageCount = 1;
    [ObservableProperty] private int _pageSize = 30;
    [ObservableProperty] private int _filteredGamesCount;

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
            RefreshPagedGames(resetToFirstPage: true);
        };

        SelectedRegions!.CollectionChanged += (s, e) =>
        {
            RefreshPagedGames(resetToFirstPage: true);
        };

        _gamesCollectionNotifier = romManager.Games as INotifyCollectionChanged;
        if (_gamesCollectionNotifier is not null)
        {
            _gamesCollectionNotifier.CollectionChanged += OnGamesCollectionChanged;
        }

        RefreshPagedGames(resetToFirstPage: true);
    }

    public Core.RomManager RomManager { get; }

    public DataGridCollectionView GamesView { get; }
    public AvaloniaList<Game> PagedGames { get; } = [];
    public bool HasPreviousPage => CurrentPage > 1;
    public bool HasNextPage => CurrentPage < PageCount;
    public string PageInfo => $"Page {CurrentPage} / {PageCount}";

    public SystemInfo?[] AvailableSystems { get; }
    public Region?[] AvailableRegions { get; }

    private bool FilterGames(object obj)
    {
        if (obj is not Game game)
        {
            return false;
        }

        var activeSystems = SelectedSystems?.Where(s => s is not null).ToArray();
        if (activeSystems is { Length: > 0 } && game.Systems.All(s => !activeSystems.Contains(s)))
        {
            return false;
        }

        var activeRegions = SelectedRegions?.Where(r => r is not null).Select(r => r!.Value).ToArray();
        if (activeRegions is { Length: > 0 } && game.Regions.All(r => !activeRegions.Contains(r)))
        {
            return false;
        }

        if (FavoritesOnly && game.Info?.IsFavorite != true)
        {
            return false;
        }

        return true;
    }

    partial void OnFavoritesOnlyChanged(bool value)
    {
        RefreshPagedGames(resetToFirstPage: true);
    }

    partial void OnCurrentPageChanged(int value)
    {
        if (value < 1)
        {
            CurrentPage = 1;
            return;
        }

        if (value > PageCount)
        {
            CurrentPage = PageCount;
            return;
        }

        RefreshPagedGames(resetToFirstPage: false);
    }

    partial void OnPageCountChanged(int value)
    {
        UpdatePaginationState();
    }

    private void OnGamesCollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
    {
        RefreshPagedGames(resetToFirstPage: false);
    }

    private void RefreshPagedGames(bool resetToFirstPage)
    {
        GamesView.Refresh();
        var filteredGames = GamesView.Cast<Game>().ToArray();
        FilteredGamesCount = filteredGames.Length;

        var newPageCount = Math.Max(1, (int)Math.Ceiling(FilteredGamesCount / (double)PageSize));
        if (PageCount != newPageCount)
        {
            PageCount = newPageCount;
        }

        if (resetToFirstPage)
        {
            CurrentPage = 1;
        }

        if (CurrentPage > PageCount)
        {
            CurrentPage = PageCount;
        }

        var skip = (CurrentPage - 1) * PageSize;
        PagedGames.Clear();
        PagedGames.AddRange(filteredGames.Skip(skip).Take(PageSize));
        UpdatePaginationState();
    }

    private void UpdatePaginationState()
    {
        OnPropertyChanged(nameof(HasPreviousPage));
        OnPropertyChanged(nameof(HasNextPage));
        OnPropertyChanged(nameof(PageInfo));
    }

    [RelayCommand]
    private void FirstPage()
    {
        CurrentPage = 1;
    }

    [RelayCommand]
    private void PreviousPage()
    {
        if (CurrentPage > 1)
        {
            CurrentPage--;
        }
    }

    [RelayCommand]
    private void NextPage()
    {
        if (CurrentPage < PageCount)
        {
            CurrentPage++;
        }
    }

    [RelayCommand]
    private void LastPage()
    {
        CurrentPage = PageCount;
    }

    [RelayCommand]
    public async Task ImportRom()
    {
        var app = App.Current ?? throw new InvalidOperationException("Application instance is not available.");
        var mainWindow = app.ApplicationLifetime is Avalonia.Controls.ApplicationLifetimes.IClassicDesktopStyleApplicationLifetime desktop
            ? desktop.MainWindow
            : null;

        var topLevel = TopLevel.GetTopLevel(mainWindow) ?? throw new InvalidOperationException("Top-level window is not available.");
        _ = await topLevel.StorageProvider.OpenFilePickerAsync(new FilePickerOpenOptions()
        {
            AllowMultiple = false,
            Title = "Select ROM to Import",
            FileTypeFilter = _filenameFilterBuilder.GetFilter()
        });
    }
}
