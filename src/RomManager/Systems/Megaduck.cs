using RomManager.Models;

namespace RomManager.Systems;

public class Megaduck: SystemInfo
{
    public override string Name { get; } = "Megaduck Cougar Boy";
    public override string Path { get; } = "megaduck";
    public override string[] Extensions { get; } = [".bin", ".duc", ".zip", ".7z"];
    public override string IconName { get; } = "megaduck.png";
}