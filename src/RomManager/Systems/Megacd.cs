using RomManager.Models;

namespace RomManager.Systems;

public class Megacd : SystemInfo
{
    public override string Name => "Sega Mega-CD";
    public override string Path => "megacd";
    public override string[] Extensions { get; } = [".cue", ".iso", ".chd", ".bin", ".zip"];
    public override string? IconName => null;
    public string[] BiosFiles { get; }
}