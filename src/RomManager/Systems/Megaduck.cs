using RomManager.Models;

namespace RomManager.Systems;

public class Megaduck: SystemInfo
{
    public override string Name => "Megaduck Cougar Boy";
    public override string Path => "megaduck";
    public override string[] Extensions { get; } = [".bin", ".duc", ".zip", ".7z"];
    public override string IconName => "megaduck.png";
}