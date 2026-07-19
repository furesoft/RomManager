using RomManager.Models;

namespace RomManager.Systems;

public class Vb: SystemInfo
{
    public override string Name { get; } = "Virtual Boy";
    public override string Path { get; } = "vb";
    public override string[] Extensions { get; } = [".vb", ".vboy", ".bin", ".zip", ".7z"];
    public override string IconName { get; } = "vb.png";
}