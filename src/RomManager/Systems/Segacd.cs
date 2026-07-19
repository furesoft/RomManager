using RomManager.Models;

namespace RomManager.Systems;

public class Segacd: SystemInfo
{
    public override string Name => "Sega CD";
    public override string Path => "segacd";
    public override string[] Extensions { get; } = [".cue", ".iso", ".chd", ".bin", ".sub", ".zip"];
    public override string IconName => "segacd.png";
}