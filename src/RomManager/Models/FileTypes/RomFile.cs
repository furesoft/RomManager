namespace RomManager.Models.FileTypes;

public class RomFile : IHasFilename
{
    public SystemInfo SystemInfo { get; set; }
    public string Filename { get; set; }
}
