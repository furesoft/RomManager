using RomManager.Models;

namespace RomManager.Systems;

public class Lutris : SystemInfo
{
    public override string Name { get; } = "Lutris";
    public override string Path { get; } = "lutris";
    public override string[] Extensions { get; } = { ".lutris", ".desktop", ".json", ".zip" };
    public override string? IconName { get; } = null;
    
}