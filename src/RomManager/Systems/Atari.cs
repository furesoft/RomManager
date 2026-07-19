using RomManager.Models;

namespace RomManager.Systems;

public class Atari : SystemInfo
{
    public override string Name => "Atari";
    public override string Path => "atari";
    public override string[] Extensions { get; } = [".car", ".rom", ".bin", ".zip"];
    public override string IconName => "atari.png";
}