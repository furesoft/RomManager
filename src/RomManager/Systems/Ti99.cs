using RomManager.Models;

namespace RomManager.Systems;

public class Ti99 : SystemInfo
{
    public override string Name => "Texas Instruments TI-99/4A";
    public override string Path => "ti99";
    public override string[] Extensions { get; } = [".bin", ".rpk", ".dsk", ".zip"];
    public override string? IconName => null;
}