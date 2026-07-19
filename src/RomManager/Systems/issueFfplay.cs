using RomManager.Models;

namespace RomManager.Systems;

public class Ftplay: SystemInfo
{
    public override string Name { get; } = "FTPlay";
    public override string Path { get; } = "ftplay";
    public override string[] Extensions { get; } = [".zip", ".7z", ".rom"];
    public override string IconName { get; } = "ffplay.png";
}