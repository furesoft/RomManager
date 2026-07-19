using RomManager.Models;

namespace RomManager.Systems;

public class Openbor: SystemInfo
{
    public override string Name { get; } = "Open Beats of Rage";
    public override string Path { get; } = "openbor";
    public override string[] Extensions { get; } = [".pak"];
    public override string IconName { get; } = "openbor.png";
}