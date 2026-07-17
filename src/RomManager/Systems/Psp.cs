using RomManager.Models;

namespace RomManager.Systems;

public class Psp: SystemInfo
{
    public override string Name { get; } = "PlayStation Portable";
    public override string Path { get; } = "psp";
    public override string[] Extensions { get; } = { ".iso", ".cso", ".pbp", ".chd", ".zip" };
    public override string IconName { get; } = "psp.png";
}