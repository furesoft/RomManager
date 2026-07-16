using RomManager.Models;

namespace RomManager.Systems;

public class Megadrive: SystemInfo
{
    public override string Name { get; } = "Sega Mega Drive";
    public override string Path { get; } = "md";
    public override string[] Extensions { get; } = { ".md", ".smd", ".bin", ".gen", ".zip", ".7z" };
    public override string IconName { get; } = "md.png";
}