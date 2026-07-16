using RomManager.Models;

namespace RomManager.Systems;

public class Stv : SystemInfo
{
    public override string Name { get; } = "Sega Titan Video";
    public override string Path { get; } = "stv";
    public override string[] Extensions { get; } = { ".zip", ".7z" };
    public override string? IconName { get; } = null;
    
}