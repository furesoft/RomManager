using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using Avalonia.Media;
using Avalonia.Media.Imaging;
using CommunityToolkit.Mvvm.ComponentModel;
using RomManager.Models.FileTypes;

namespace RomManager.Models;

public partial class Game : ObservableObject
{
    [ObservableProperty]
    private string _name = "";

    [ObservableProperty]
    private IEnumerable<IHasFilename> _files = [];

    [ObservableProperty] private IImage? _coverArt;

    [ObservableProperty] private SystemInfo[] _systems;

    public void Load()
    {
        var art = Files.OfType<CoverArtImage>().FirstOrDefault();
        if (art != null && File.Exists(art.Filename))
        {
            CoverArt = new Bitmap(art.Filename);
        }

        Systems = Files.OfType<RomFile>().Select(f => f.SystemInfo).ToArray();
    }

    public override string ToString()
    {
        return Name;
    }
}