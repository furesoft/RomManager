using RomManager.Models;

namespace RomManager.Systems;

public class Atari : SystemInfo
{
    public override string Name { get; } = "Atari";
    public override string Path { get; } = "atari";
    public override string[] Extensions { get; } = { ".car", ".rom", ".bin", ".zip" };
    public override string IconName { get; } = "atari.png";
}