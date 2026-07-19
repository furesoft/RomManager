using RomManager.Models;

namespace RomManager.Systems;

public class Ps1 : SystemInfo
{
    public override string Name { get; } = "PS1";
    public override string Path { get; } = "psx";
    public override string[] Extensions { get; } = [".bin", ".chd"];
    public override string IconName { get; } = "psx.png";
}
