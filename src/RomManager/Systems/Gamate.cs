using RomManager.Models;

namespace RomManager.Systems;

public class Gamate : SystemInfo
{
    public override string Name => "Bit Corporation Gamate";
    public override string Path => "gamate";
    public override string[] Extensions { get; } = [".gam", ".bin", ".zip"];
    public override string? IconName => null;
}
