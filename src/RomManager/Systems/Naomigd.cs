using RomManager.Models;

namespace RomManager.Systems;

public class Naomigd : SystemInfo
{
    public override string Name { get; } = "Sega NAOMI GD-ROM";
    public override string Path { get; } = "naomigd";
    public override string[] Extensions { get; } = [".zip", ".7z", ".dat", ".chd"];
    public override string? IconName { get; } = null;
}