using RomManager.Models;

namespace RomManager.Systems;

public class Gmaster : SystemInfo
{
    public override string Name => "Game Master";
    public override string Path => "gmaster";
    public override string[] Extensions { get; } = [".bin"];
    public override string? IconName => null;
}
