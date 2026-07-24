using RomManager.Models;

namespace RomManager.Systems;

public class Atarist : SystemInfo
{
    public override string Name => "Atarist";
    public override string Path => "atarist";
    public override string[] Extensions { get; } = [".car", ".rom", ".bin", ".zip"];
    public override string IconName => "atarist.png";
}
