using RomManager.Models;

namespace RomManager.Systems;

public class SatellaView : SystemInfo
{
    public override string Name => "Satellaview";
    public override string Path => "satella";
    public override string[] Extensions { get; } = [".bs", ".sfc", ".smc", ".zip", ".7z"];
    public override string IconName => "satella.png";
}
