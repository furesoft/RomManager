using RomManager.Models;

namespace RomManager.Systems;

public class Pico8: SystemInfo
{
    public override string Name => "Sega Pico";
    public override string Path => "pico";
    public override string[] Extensions { get; } = [".bin", ".md", ".zip", ".7z"];
    public override string IconName => "pico.png";
}