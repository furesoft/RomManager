using RomManager.Models;

namespace RomManager.Systems;

public class Daphne : SystemInfo
{
    public override string Name => "LaserDisc Arcade";
    public override string Path => "daphne";
    public override string[] Extensions { get; } = [".daphne", ".squashfs", ".zip"];
    public override string? IconName => null;
}
