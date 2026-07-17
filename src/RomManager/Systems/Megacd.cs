using RomManager.Models;

namespace RomManager.Systems;

public class Megacd : SystemInfo
{
    public override string Name { get; } = "Sega Mega-CD";
    public override string Path { get; } = "megacd";
    public override string[] Extensions { get; } = { ".cue", ".iso", ".chd", ".bin", ".zip" };
    public override string? IconName { get; } = null;
    
}