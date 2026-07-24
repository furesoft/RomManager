using RomManager.Models;

namespace RomManager.Systems;

public class Sg1000 : SystemInfo
{
    public override string Name => "Sega SG-1000";
    public override string Path => "sg1000";
    public override string[] Extensions { get; } = [".sg", ".bin", ".zip"];
    public override string? IconName => null;
}
