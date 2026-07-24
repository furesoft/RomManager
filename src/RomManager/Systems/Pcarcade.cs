using RomManager.Models;

namespace RomManager.Systems;

public class Pcarcade : SystemInfo
{
    public override string Name => "PC Arcade";
    public override string Path => "pcarcade";
    public override string[] Extensions { get; } = [".lnk", ".bat", ".exe", ".cmd", ".zip"];
    public override string? IconName => null;
}
