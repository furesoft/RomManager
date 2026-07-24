using RomManager.Models;

namespace RomManager.Systems;

public class Stv : SystemInfo
{
    public override string Name => "Sega Titan Video";
    public override string Path => "stv";
    public override string[] Extensions { get; } = [".zip", ".7z"];
    public override string? IconName => null;
}
