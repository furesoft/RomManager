using RomManager.Models;

namespace RomManager.Systems;

public class Cps1 : SystemInfo
{
    public override string Name => "Capcom Play System 1";
    public override string Path => "cps1";
    public override string[] Extensions { get; } = [".zip", ".7z"];
    public override string IconName => "cps1.png";
}
