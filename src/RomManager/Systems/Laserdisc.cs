using RomManager.Models;

namespace RomManager.Systems;

public class Laserdisc:SystemInfo
{
    public override string Name { get; } = "LaserDisc Arcade";
    public override string Path { get; } = "daphne";
    public override string[] Extensions { get; } = [".daphne", ".squashfs", ".zip"];
    public override string? IconName { get; } = null;
}