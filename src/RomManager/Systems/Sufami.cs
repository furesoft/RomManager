using RomManager.Models;

namespace RomManager.Systems;

public class Sufami: SystemInfo
{
    public override string Name { get; } = "Sufami Turbo";
    public override string Path { get; } = "sufami";
    public override string[] Extensions { get; } = [".st", ".sfc", ".rom", ".zip", ".7z"];
    public override string IconName { get; } = "sufami.png";
}