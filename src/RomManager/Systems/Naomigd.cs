using RomManager.Models;

namespace RomManager.Systems;

public class Naomigd : SystemInfo
{
    public override string Name => "Sega NAOMI GD-ROM";
    public override string Path => "naomigd";
    public override string[] Extensions { get; } = [".zip", ".7z", ".dat", ".chd"];
    public override string? IconName => null;
}
