using RomManager.Models;

namespace RomManager.Systems;

public class Atari800 : SystemInfo
{
    public override string Name => "Atari";
    public override string Path => "atari800";
    public override string[] Extensions { get; } = [".car", ".rom", ".bin", ".zip"];
    public override string? IconName => "atari800.png";
}
