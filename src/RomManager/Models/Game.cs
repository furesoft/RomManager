using System.Collections.Generic;
using System.IO;
using System.Linq;
using Avalonia.Media;
using Avalonia.Media.Imaging;
using CommunityToolkit.Mvvm.ComponentModel;
using RomManager.Core.RegionDetection;
using RomManager.Models.FileTypes;

namespace RomManager.Models;

public partial class Game : ObservableObject
{
    [ObservableProperty] private IImage? _coverArt;

    [ObservableProperty] private IEnumerable<IHasFilename> _files = [];

    [ObservableProperty] private GameInfo? _info;

    [ObservableProperty] private string _name = "";

    [ObservableProperty] private Region[] _regions = [Region.Unknown];

    [ObservableProperty] private SystemInfo[] _systems;

    public void Load()
    {
        var art = Files.OfType<CoverArtImage>().FirstOrDefault();
        if (art != null && File.Exists(art.Filename)) CoverArt = new Bitmap(art.Filename);

        Systems = Files.OfType<RomFile>().Select(f => f.SystemInfo).ToArray();

        // Detect regions from the ROM file
        var romFile = Files.OfType<RomFile>().FirstOrDefault();
        if (romFile != null && File.Exists(romFile.Filename))
            Regions = RegionDetectorFactory.DetectRegions(romFile.Filename);

        Name = Info!.Name;
    }

    public override string ToString()
    {
        return Name;
    }
}
