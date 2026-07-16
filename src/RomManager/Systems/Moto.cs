using RomManager.Models;

namespace RomManager.Systems;

public class Moto : SystemInfo
{
    public override string Name { get; } = "Thomson MO/TO";
    public override string Path { get; } = "moto";
    public override string[] Extensions { get; } = { ".fd", ".sap", ".k7", ".rom", ".m7", ".m5", ".zip" };
    public override string? IconName { get; } = null;
    
}