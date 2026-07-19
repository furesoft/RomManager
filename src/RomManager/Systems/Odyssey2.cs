using RomManager.Models;

namespace RomManager.Systems;

public class Odyssey2: SystemInfo
{
    public override string Name { get; } = "Magnavox Odyssey";
    public override string Path { get; } = "ody";
    public override string[] Extensions { get; } = [".bin", ".rom", ".zip", ".7z"];
    public override string IconName { get; } = "ody.png";
}