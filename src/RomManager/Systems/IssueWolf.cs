using RomManager.Models;

namespace RomManager.Systems;

public class IssueWolf: SystemInfo
{
    public override string Name { get; } = "Wolfenstein 3D Engine";
    public override string Path { get; } = "wolf";
    public override string[] Extensions { get; } = { ".sh", ".ecwolf", ".pk3", ".wl6", ".zip" };
    public override string IconName { get; } = "wolf.png";
}