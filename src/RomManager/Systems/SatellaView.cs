using RomManager.Models;

namespace RomManager.Systems;

public class SatellaView: SystemInfo
{
    public override string Name { get; } = "Satellaview";
    public override string Path { get; } = "satella";
    public override string[] Extensions { get; } = [".bs", ".sfc", ".smc", ".zip", ".7z"];
    public override string IconName { get; } = "satella.png";
}