using RomManager.Models;

namespace RomManager.Systems;

public class Atari5200 : SystemInfo
{
    public override string Name => "Atari 5200";
    public override string Path => "atari5200";
    public override string[] Extensions { get; } = [".a52", ".bin", ".rom", ".zip", ".7z"];
    public override string? IconName => null;
    public string[] BiosFiles { get; }
}