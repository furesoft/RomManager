using RomManager.Models;

namespace RomManager.Systems;

public class Megacdjp : SystemInfo
{
    public override string Name { get; } = "Sega Mega-CD Japan";
    public override string Path { get; } = "megacdjp";
    public override string[] Extensions { get; } = { ".cue", ".iso", ".chd", ".bin", ".zip" };
    public override string? IconName { get; } = null;
}