using RomManager.Models;

namespace RomManager.Systems;

public class Openbor : SystemInfo
{
    public override string Name => "Open Beats of Rage";
    public override string Path => "openbor";
    public override string[] Extensions { get; } = [".pak"];
    public override string IconName => "openbor.png";
}
