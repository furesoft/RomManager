using RomManager.Models;

namespace RomManager.Systems;

public class Vdp: SystemInfo
{
    public override string Name => "Video Dynamic Processor";
    public override string Path => "vdp";
    public override string[] Extensions { get; } = [".bin", ".rom", ".zip", ".7z"];
    public override string IconName => "vdp.png";
}