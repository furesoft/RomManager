using RomManager.Models;

namespace RomManager.Systems;

public class NES : SystemInfo
{
    public override string Name { get; } = "NES";
    public override string Path { get; } = "nes";
    public override string[] Extensions { get; } = {".nes", ".zip" };
    public override string IconName { get; } = "nes.png";
}