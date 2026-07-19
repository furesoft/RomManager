using RomManager.Models;

namespace RomManager.Systems;

public class Vb: SystemInfo
{
    public override string Name => "Virtual Boy";
    public override string Path => "vb";
    public override string[] Extensions { get; } = [".vb", ".vboy", ".bin", ".zip", ".7z"];
    public override string IconName => "vb.png";
}