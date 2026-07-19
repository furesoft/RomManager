using RomManager.Models;

namespace RomManager.Systems;

public class Psx : SystemInfo
{
    public override string Name => "PlayStation 1";
    public override string Path => "psx";
    public override string[] Extensions { get; } = [".cue", ".bin", ".chd", ".pbp", ".iso"];
    public override string? IconName => "psx.png";
}
