using RomManager.Models;

namespace RomManager.Systems;

public class issueC64: SystemInfo
{
    public override string Name { get; } = "C64";
    public override string Path { get; } = "c64";
    public override string[] Extensions { get; } = [".car", ".rom", ".bin", ".zip"];
    public override string IconName { get; } = "c64.png";
}