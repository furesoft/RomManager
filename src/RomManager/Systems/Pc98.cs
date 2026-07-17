using RomManager.Models;

namespace RomManager.Systems;

public class Pc98 : SystemInfo
{
    public override string Name { get; } = "NEC PC-9801";
    public override string Path { get; } = "pc98";
    public override string[] Extensions { get; } = { ".d98", ".hdi", ".fdi", ".nhd", ".dsk", ".m3u", ".cmd", ".zip" };
    public override string? IconName { get; } = null;
    
}