using RomManager.Models;

namespace RomManager.Systems;

public class Msumd : SystemInfo
{
    public override string Name { get; } = "Sega Genesis MSU-MD";
    public override string Path { get; } = "msumd";
    public override string[] Extensions { get; } = [".md", ".bin", ".zip"];
    public override string IconName { get; } = "msumd.png";
}