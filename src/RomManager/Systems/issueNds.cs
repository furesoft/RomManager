using RomManager.Models;

namespace RomManager.Systems;

public class issueNds : SystemInfo
{
    public override string Name => "Nintendo DS";
    public override string Path => "nds";
    public override string[] Extensions { get; } = [".nds", ".dsi", ".zip", ".7z"];
    public override string IconName => "nds.png";
}
