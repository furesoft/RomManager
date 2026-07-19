using RomManager.Models;

namespace RomManager.Systems;

public class Vdp: SystemInfo
{
    public override string Name { get; } = "Video Dynamic Processor";
    public override string Path { get; } = "vdp";
    public override string[] Extensions { get; } = [".bin", ".rom", ".zip", ".7z"];
    public override string IconName { get; } = "vdp.png";
}