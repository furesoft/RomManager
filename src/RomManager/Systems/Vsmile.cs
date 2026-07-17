using RomManager.Models;

namespace RomManager.Systems;

public class Vsmile : SystemInfo
{
    public override string Name { get; } = "VTech V.Smile";
    public override string Path { get; } = "vsmile";
    public override string[] Extensions { get; } = { ".bin", ".zip", ".7z" };
    public override string? IconName { get; } = null;
}