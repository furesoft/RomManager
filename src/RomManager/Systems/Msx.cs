using RomManager.Models;

namespace RomManager.Systems;

public class Msx : SystemInfo
{
    public override string Name => "MSX";
    public override string Path => "msx";
    public override string[] Extensions { get; } = [".rom", ".mx1", ".mx2", ".dsk", ".cas", ".zip"];
    public override string IconName => "msx.png";
}
