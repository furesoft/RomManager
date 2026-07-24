using RomManager.Models;

namespace RomManager.Systems;

public class Psp : SystemInfo
{
    public override string Name => "PlayStation Portable";
    public override string Path => "psp";
    public override string[] Extensions { get; } = [".iso", ".cso", ".pbp", ".chd", ".zip"];
    public override string IconName => "psp.png";
    public string[] BiosFiles { get; }
}
