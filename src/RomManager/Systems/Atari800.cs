using RomManager.Models;

namespace RomManager.Systems;

public class Atari800 : SystemInfo
{
    public override string Name { get; } = "Atari";
    public override string Path { get; } = "atari800";
    public override string[] Extensions { get; } = { ".car", ".rom", ".bin", ".zip" };
    public override string IconName { get; } = "atari800.png";
}