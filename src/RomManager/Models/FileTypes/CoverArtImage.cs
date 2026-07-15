using System.IO;
using Avalonia.Media;
using Avalonia.Media.Imaging;

namespace RomManager.Models.FileTypes;

public class CoverArtImage : IHasFilename
{
    public string Filename { get; set; }
}