using RomManager.Models;

namespace RomManager.Systems;

public class Sufami : SystemInfo
{
    public override string Name => "Sufami Turbo";
    public override string Path => "sufami";
    public override string[] Extensions { get; } = [".st", ".sfc", ".rom", ".zip", ".7z"];
    public override string IconName => "sufami.png";
}
