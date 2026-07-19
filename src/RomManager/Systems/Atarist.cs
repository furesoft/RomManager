using RomManager.Models;

namespace RomManager.Systems;

public class Atarist: SystemInfo
{
    public override string Name { get; } = "Atarist";
    public override string Path { get; } = "atarist";
    public override string[] Extensions { get; } = [".car", ".rom", ".bin", ".zip"];
    public override string IconName { get; } = "atarist.png";
}