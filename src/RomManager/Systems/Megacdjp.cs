using RomManager.Models;

namespace RomManager.Systems;

public class Megacdjp : SystemInfo
{
    public override string Name => "Sega Mega-CD Japan";
    public override string Path => "megacdjp";
    public override string[] Extensions { get; } = [".cue", ".iso", ".chd", ".bin", ".zip"];
    public override string? IconName => null;
}