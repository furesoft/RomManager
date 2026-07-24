using RomManager.Models;

namespace RomManager.Systems;

public class Dreamcast : SystemInfo
{
    public override string Name => "Sega Dreamcast";
    public override string Path => "dc";
    public override string[] Extensions { get; } = [".gdi", ".cdi", ".chd", ".iso", ".zip"];
    public override string IconName => "dc.png";
}
