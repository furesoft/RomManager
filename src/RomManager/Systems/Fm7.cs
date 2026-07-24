using RomManager.Models;

namespace RomManager.Systems;

public class Fm7 : SystemInfo
{
    public override string Name => "Fujitsu FM-7";
    public override string Path => "fm7";
    public override string[] Extensions { get; } = [".d77", ".dsk", ".t77", ".tfd", ".m3u", ".zip"];
    public override string? IconName => null;
}
