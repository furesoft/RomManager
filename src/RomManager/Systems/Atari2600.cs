using RomManager.Models;

namespace RomManager.Systems;

public class Atari2600 : SystemInfo
{
    public override string Name { get; } = "Atari 2600";
    public override string Path { get; } = "atari2600";
    public override string[] Extensions { get; } = { ".a26", ".bin", ".rom", ".zip", ".7z" };
    public override string? IconName { get; } = null;
}