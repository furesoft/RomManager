using RomManager.Models;

namespace RomManager.Systems;

public class Sega32xjp : SystemInfo
{
    public override string Name { get; } = "Sega 32X Japan";
    public override string Path { get; } = "sega32xjp";
    public override string[] Extensions { get; } = { ".32x", ".bin", ".md", ".zip" };
    public override string? IconName { get; } = null;
}