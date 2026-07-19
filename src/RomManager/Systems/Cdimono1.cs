using RomManager.Models;

namespace RomManager.Systems;

public class Cdimono1 : SystemInfo
{
    public override string Name => "Philips CD-i (Mono-1)";
    public override string Path => "cdimono1";
    public override string[] Extensions { get; } = [".cue", ".chd", ".iso", ".bin", ".zip"];
    public override string? IconName => null;
}