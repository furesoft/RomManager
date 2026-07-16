using RomManager.Models;

namespace RomManager.Systems;

public class Flash : SystemInfo
{
    public override string Name { get; } = "Adobe Flash Player";
    public override string Path { get; } = "flash";
    public override string[] Extensions { get; } = { ".swf", ".exe", ".zip" };
    public override string? IconName { get; } = null;
    
}