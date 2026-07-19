using RomManager.Models;

namespace RomManager.Systems;

public class X1 : SystemInfo
{
    public override string Name => "Sharp X1";
    public override string Path => "x1";
    public override string[] Extensions { get; } = [".d88", ".dsk", ".tap", ".m3u", ".zip"];
    public override string? IconName => null;
}