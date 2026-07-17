using RomManager.Models;

namespace RomManager.Systems;

public class Gamate : SystemInfo
{
    public override string Name { get; } = "Bit Corporation Gamate";
    public override string Path { get; } = "gamate";
    public override string[] Extensions { get; } = { ".gam", ".bin", ".zip" };
    public override string? IconName { get; } = null;
    
}