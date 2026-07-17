using RomManager.Models;

namespace RomManager.Systems;

public class Macintosh : SystemInfo
{
    public override string Name { get; } = "Apple Macintosh";
    public override string Path { get; } = "macintosh";
    public override string[] Extensions { get; } = { ".dsk", ".img", ".iso", ".hqx", ".sit", ".zip" };
    public override string? IconName { get; } = null;
    
}