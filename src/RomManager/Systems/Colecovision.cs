using RomManager.Models;

namespace RomManager.Systems;

public class Colecovision : SystemInfo
{
    public override string Name { get; } = "ColecoVision";
    public override string Path { get; } = "colecovision";
    public override string[] Extensions { get; } = { ".col", ".bin", ".rom", ".zip", ".7z" };
    public override string? IconName { get; } = null;
}