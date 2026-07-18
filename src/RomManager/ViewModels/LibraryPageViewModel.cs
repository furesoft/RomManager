using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Extensions.Options;
using RomManager.Configurations;
using RomManager.Models;

namespace RomManager.ViewModels;

public partial class LibraryPageViewModel : ObservableObject
{
    public Core.RomManager RomManager { get; }
    public ObservableCollection<Game> Games { get; set; }

    public LibraryPageViewModel(Core.RomManager romManager, IOptions<PathsConfiguration> pathsConfiguration)
    {
        RomManager = romManager;

        Games = new(romManager.Games);
    }

}