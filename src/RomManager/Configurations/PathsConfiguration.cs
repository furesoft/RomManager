namespace RomManager.Configurations;

public sealed class PathsConfiguration
{
    public const string SectionName = "Paths";

    public string BasePath { get; set; } = string.Empty;
    public string Roms { get; set; } = string.Empty;
    public string SaveGames { get; set; } = string.Empty;
    public string Media { get; set; } = string.Empty;
}
