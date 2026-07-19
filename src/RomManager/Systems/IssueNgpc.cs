using RomManager.Models;

namespace RomManager.Systems;

public class issueC64: SystemInfo
{
    public override string Name => "C64";
    public override string Path => "c64";
    public override string[] Extensions { get; } = [".car", ".rom", ".bin", ".zip"];
    public override string IconName => "c64.png";
}