using RomManager.Models;

namespace RomManager.Systems;

public class Neogeo : SystemInfo
{
    public override string Name => "SNK Neo Geo Pocket Color";
    public override string Path => "ngpc";
    public override string[] Extensions { get; } = [".ngc", ".ngp", ".npc", ".zip", ".7z"];
    public override string IconName => "neogeo.png";
}
