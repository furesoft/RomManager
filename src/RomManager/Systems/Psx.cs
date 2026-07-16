using RomManager.Models;

namespace RomManager.Systems;

public class Psx : SystemInfo
{
    public override string Name { get; } = "PlayStation";
    public override string Path { get; } = "psx";
    public override string[] Extensions { get; } = { ".cue", ".bin", ".chd", ".pbp", ".iso" };
    public override string? IconName { get; } = null;
}