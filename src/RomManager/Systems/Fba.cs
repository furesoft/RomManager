using RomManager.Models;

namespace RomManager.Systems;

public class Fba : SystemInfo
{
    public override string Name { get; } = "FinalBurn Alpha";
    public override string Path { get; } = "fba";
    public override string[] Extensions { get; } = { ".zip", ".7z", ".fba" };
    public override string? IconName { get; } = null;
    
}
