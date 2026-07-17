using RomManager.Models;

namespace RomManager.Systems;

public class Gameandwatch : SystemInfo
{
    public override string Name { get; } = "Nintendo Game & Watch";
    public override string Path { get; } = "gameandwatch";
    public override string[] Extensions { get; } = { ".mgw", ".zip" };
    public override string? IconName { get; } = null;
    
}