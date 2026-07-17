using RomManager.Models;

namespace RomManager.Systems;

public class Supervision: SystemInfo
{
    public override string Name { get; } = "Watara Supervision";
    public override string Path { get; } = "supervision";
    public override string[] Extensions { get; } = { ".sv", ".bin", ".rom", ".zip", ".7z" };
    public override string IconName { get; } = "supervision.png";
}