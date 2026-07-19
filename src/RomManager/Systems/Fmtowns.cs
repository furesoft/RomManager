using RomManager.Models;

namespace RomManager.Systems;

public class Fmtowns : SystemInfo
{
    public override string Name { get; } = "Fujitsu FM Towns";
    public override string Path { get; } = "fmtowns";
    public override string[] Extensions { get; } = [".cue", ".iso", ".chd", ".bin", ".m3u", ".zip"];
    public override string? IconName { get; } = null;
}