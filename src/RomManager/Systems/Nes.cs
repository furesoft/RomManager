using RomManager.Models;

namespace RomManager.Systems;

public class Nes : SystemInfo
{
    public override string Name => "NES";
    public override string Path => "nes";
    public override string[] Extensions { get; } = [".nes", ".zip"];
    public override string IconName => "fc.png";
}