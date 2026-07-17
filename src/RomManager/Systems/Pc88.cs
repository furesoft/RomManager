using RomManager.Models;

namespace RomManager.Systems;

public class Pc88 : SystemInfo
{
    public override string Name { get; } = "NEC PC-8801";
    public override string Path { get; } = "pc88";
    public override string[] Extensions { get; } = { ".d88", ".dsk", ".m3u", ".cmd", ".zip" };
    public override string? IconName { get; } = null;
}