using RomManager.Models;

namespace RomManager.Systems;

public class Quake: SystemInfo
{
    public override string Name => "Quake Engine";
    public override string Path => "quake";
    public override string[] Extensions { get; } = [".pak", ".pak0.pak", ".engine", ".sh", ".zip"];
    public override string IconName => "quake.png";
}