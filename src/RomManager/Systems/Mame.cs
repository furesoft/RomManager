using RomManager.Models;

namespace RomManager.Systems;

public class Mame: SystemInfo
{
    public override string Name { get; } = "Multiple Arcade Machine Emulator";
    public override string Path { get; } = "mame";
    public override string[] Extensions { get; } = { ".zip", ".7z", ".chd" };
    public override string IconName { get; } = "mame.png";
}