using RomManager.Models;

namespace RomManager.Systems;

public class Atari7800 : SystemInfo
{
    public override string Name => "Atari 7800";
    public override string Path => "atari7800";
    public override string[] Extensions { get; } = [".a78", ".bin", ".rom", ".zip", ".7z"];
    public override string? IconName => null;
}