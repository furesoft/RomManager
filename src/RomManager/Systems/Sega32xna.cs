using RomManager.Models;

namespace RomManager.Systems;

public class Sega32xna : SystemInfo
{
    public override string Name => "Sega 32X North America";
    public override string Path => "sega32xna";
    public override string[] Extensions { get; } = [".32x", ".bin", ".md", ".zip"];
    public override string? IconName => null;
}
