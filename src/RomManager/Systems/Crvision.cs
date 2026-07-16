using RomManager.Models;

namespace RomManager.Systems;

public class Crvision : SystemInfo
{
    public override string Name { get; } = "VTech CreatiVision";
    public override string Path { get; } = "crvision";
    public override string[] Extensions { get; } = { ".bin", ".rom" };
    public override string? IconName { get; } = null;
}