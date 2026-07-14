using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Extensions.Options;
using RomManager.Configurations;
using RomManager.Models;
using RomManager.Models.FileTypes;
using RomManager.Systems;

namespace RomManager.ViewModels;

public partial class LibraryPageViewModel : ObservableObject
{
    public ObservableCollection<Game> Games { get; set; }

    public LibraryPageViewModel(N64 system, IOptions<PathsConfiguration> pathsConfiguration)
    {
        var games = system.GetGames(pathsConfiguration.Value);
        Games = new(games);
    }
}