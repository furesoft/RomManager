using RomManager.Models;

namespace RomManager.Systems;

public class Atari5200 : SystemInfo
{
    public override string Name { get; } = "Atari 5200";
    public override string Path { get; } = "atari5200";
    public override string[] Extensions { get; } = { ".a52", ".bin", ".rom", ".zip", ".7z" };
    public override string? IconName { get; } = null;
}