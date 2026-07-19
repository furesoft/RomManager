using RomManager.Models;

namespace RomManager.Systems;

public class Atari7800 : SystemInfo
{
    public override string Name { get; } = "Atari 7800";
    public override string Path { get; } = "atari7800";
    public override string[] Extensions { get; } = [".a78", ".bin", ".rom", ".zip", ".7z"];
    public override string? IconName { get; } = null;
}