using RomManager.Models;

namespace RomManager.Systems;

public class Sgb : SystemInfo
{
    public override string Name => "Super Game Boy";
    public override string Path => "sgb";
    public override string[] Extensions { get; } = [".gb", ".sgb", ".zip", ".7z"];
    public override string IconName => "sgb.png";
}
