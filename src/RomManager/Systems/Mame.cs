using RomManager.Models;

namespace RomManager.Systems;

public class Mame : SystemInfo
{
    public override string Name => "MAME";
    public override string Path => "mame";
    public override string[] Extensions { get; } = [".zip", ".7z", ".chd"];
    public override string IconName => "mame.png";
}