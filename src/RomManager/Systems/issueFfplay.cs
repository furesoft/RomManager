using RomManager.Models;

namespace RomManager.Systems;

public class Ftplay: SystemInfo
{
    public override string Name => "FTPlay";
    public override string Path => "ftplay";
    public override string[] Extensions { get; } = [".zip", ".7z", ".rom"];
    public override string IconName => "ffplay.png";
}