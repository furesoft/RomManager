namespace RomManager.Models.FileTypes;

public class RomFile : IHasFilename
{
    public string Filename { get; set; }
    public SystemInfo SystemInfo { get; set; }
}