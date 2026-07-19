using RomManager.Models;

namespace RomManager.Systems;

public class Quake: SystemInfo
{
    public override string Name { get; } = "Quake Engine";
    public override string Path { get; } = "quake";
    public override string[] Extensions { get; } = [".pak", ".pak0.pak", ".engine", ".sh", ".zip"];
    public override string IconName { get; } = "quake.png";
}