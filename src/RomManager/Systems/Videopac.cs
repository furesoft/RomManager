using RomManager.Models;

namespace RomManager.Systems;

public class Videopac : SystemInfo
{
    public override string Name { get; } = "Magnavox Odyssey 2 / Philips Videopac";
    public override string Path { get; } = "videopac";
    public override string[] Extensions { get; } = { ".bin", ".rom", ".zip" };
    public override string? IconName { get; } = null;
}