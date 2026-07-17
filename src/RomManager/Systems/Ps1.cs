using RomManager.Models;

namespace RomManager.Systems;

public class Ps1 : SystemInfo
{
    public override string Name { get; } = "PS1";
    public override string Path { get; } = "ps1";
    public override string[] Extensions { get; } = {".bin", ".zip" };
    public override string IconName { get; } = "ps.png";
}