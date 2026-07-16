using RomManager.Models;

namespace RomManager.Systems;

public class Intellivision : SystemInfo
{
    public override string Name { get; } = "Mattel Intellivision";
    public override string Path { get; } = "intellivision";
    public override string[] Extensions { get; } = { ".int", ".bin", ".rom", ".zip" };
    public override string? IconName { get; } = null;
    
}