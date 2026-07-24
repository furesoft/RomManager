using RomManager.Models;

namespace RomManager.Systems;

public class Cpc : SystemInfo
{
    public override string Name => "Amstrad CPC";
    public override string Path => "cpc";
    public override string[] Extensions { get; } = [".rom", ".cpr", ".exx", ".zip"];
    public override string IconName => "c64.png";
}
