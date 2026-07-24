using RomManager.Models;

namespace RomManager.Systems;

public class Megadrive : SystemInfo
{
    public override string Name => "Sega Mega Drive";
    public override string Path => "megadrive";
    public override string[] Extensions { get; } = [".md", ".smd", ".bin", ".gen", ".zip", ".7z"];
    public override string IconName => "md.png";
}
