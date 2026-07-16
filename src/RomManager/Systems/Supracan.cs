using RomManager.Models;

namespace RomManager.Systems;

public class Supracan : SystemInfo
{
    public override string Name { get; } = "Super A'Can";
    public override string Path { get; } = "supracan";
    public override string[] Extensions { get; } = { ".can", ".bin", ".zip" };
    public override string? IconName { get; } = null;
    
}