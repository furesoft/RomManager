using RomManager.Models;

namespace RomManager.Systems;

public class Msumd : SystemInfo
{
    public override string Name => "Sega Genesis MSU-MD";
    public override string Path => "msumd";
    public override string[] Extensions { get; } = [".md", ".bin", ".zip"];
    public override string IconName => "msumd.png";
}
