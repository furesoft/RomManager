using RomManager.Models;

namespace RomManager.Systems;

public class Crvision : SystemInfo
{
    public override string Name => "VTech CreatiVision";
    public override string Path => "crvision";
    public override string[] Extensions { get; } = [".bin", ".rom"];
    public override string? IconName => null;
}