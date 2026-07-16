using RomManager.Models;

namespace RomManager.Systems;

public class Pico8: SystemInfo
{
    public override string Name { get; } = "Sega Pico";
    public override string Path { get; } = "pico";
    public override string[] Extensions { get; } = { ".bin", ".md", ".zip", ".7z" };
    public override string IconName { get; } = "pico.png";
}