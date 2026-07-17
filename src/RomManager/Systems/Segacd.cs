using RomManager.Models;

namespace RomManager.Systems;

public class Segacd: SystemInfo
{
    public override string Name { get; } = "Sega CD";
    public override string Path { get; } = "segacd";
    public override string[] Extensions { get; } = { ".cue", ".iso", ".chd", ".bin", ".sub", ".zip" };
    public override string IconName { get; } = "segacd.png";
}