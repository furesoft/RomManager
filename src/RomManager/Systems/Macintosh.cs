using RomManager.Models;

namespace RomManager.Systems;

public class Macintosh : SystemInfo
{
    public override string Name => "Apple Macintosh";
    public override string Path => "macintosh";
    public override string[] Extensions { get; } = [".dsk", ".img", ".iso", ".hqx", ".sit", ".zip"];
    public override string? IconName => null;
}
