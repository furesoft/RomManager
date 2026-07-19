using RomManager.Models;

namespace RomManager.Systems;

public class Nes : SystemInfo
{
    public override string Name { get; } = "NES";
    public override string Path { get; } = "nes";
    public override string[] Extensions { get; } = [".nes", ".zip"];
    public override string IconName { get; } = "fc.png";
}