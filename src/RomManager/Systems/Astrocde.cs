using RomManager.Models;

namespace RomManager.Systems;

public class Astrocde : SystemInfo
{
    public override string Name { get; } = "Bally Astrocade";
    public override string Path { get; } = "astrocde";
    public override string[] Extensions { get; } = [".bin", ".rom", ".zip"];
    public override string IconName { get; } = "astrocde.png";
}