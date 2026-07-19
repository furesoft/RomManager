using RomManager.Models;

namespace RomManager.Systems;

public class Ps2 : SystemInfo
{
    public override string Name { get; } = "PS2";
    public override string Path { get; } = "ps2";
    public override string[] Extensions { get; } = [".iso","chd","cso", ".zip"];
    public override string IconName { get; } = "ps2.png";
}