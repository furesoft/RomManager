using RomManager.Models;

namespace RomManager.Systems;

public class Cdimono1 : SystemInfo
{
    public override string Name { get; } = "Philips CD-i (Mono-1)";
    public override string Path { get; } = "cdimono1";
    public override string[] Extensions { get; } = [".cue", ".chd", ".iso", ".bin", ".zip"];
    public override string? IconName { get; } = null;
}