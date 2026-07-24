using RomManager.Models;

namespace RomManager.Systems;

public class Cps2 : SystemInfo
{
    public override string Name => "Capcom Play System 2";
    public override string Path => "cps1";
    public override string[] Extensions { get; } = [".zip", ".7z"];
    public override string IconName => "cps2.png";
}
