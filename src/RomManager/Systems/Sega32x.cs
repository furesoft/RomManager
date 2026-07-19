using RomManager.Models;

namespace RomManager.Systems;

public class Sega32x : SystemInfo
{
    public override string Name { get; } = "Sega 32X";
    public override string Path { get; } = "sega32x";
    public override string[] Extensions { get; } = [".32x", ".bin", ".md", ".zip"];
    public override string? IconName { get; } = null;
}