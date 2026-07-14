using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace RomManager.Models;

public partial class Game : ObservableObject
{
    [ObservableProperty]
    private string _name = "";

    [ObservableProperty]
    private ObservableCollection<IFilename> _files = [];
}