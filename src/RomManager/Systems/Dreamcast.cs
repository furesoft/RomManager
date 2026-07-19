using RomManager.Models;

namespace RomManager.Systems;

public class Dreamcast: SystemInfo
{
    public override string Name { get; } = "Sega Dreamcast";
    public override string Path { get; } = "dc";
    public override string[] Extensions { get; } = [".gdi", ".cdi", ".chd", ".iso", ".zip"];
    public override string IconName { get; } = "dc.png";
}