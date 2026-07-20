using RomManager.Models;

namespace RomManager.Systems;

public class Ps2 : SystemInfo
{
    public override string Name => "PS2";
    public override string Path => "ps2";
    public override string[] Extensions { get; } = [".iso","chd","cso", ".zip"];
    public override string IconName => "ps.png";
    public string[] BiosFiles { get; }
}