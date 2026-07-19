using RomManager.Models;

namespace RomManager.Systems;

public class Gc: SystemInfo
{
    public override string Name => "Sega Game Gear";
    public override string Path => "gg";
    public override string[] Extensions { get; } = [".gg", ".sms", ".bin", ".zip", ".7z"];
    public override string IconName => "gg.png";
}