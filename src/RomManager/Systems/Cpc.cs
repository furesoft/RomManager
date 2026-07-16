using RomManager.Models;

namespace RomManager.Systems;

public class Cpc: SystemInfo
{
    public override string Name { get; } = "Amstrad CPC";
    public override string Path { get; } = "cpc";
    public override string[] Extensions { get; } = { ".rom", ".cpr", ".exx", ".zip" };
    public override string IconName { get; } = "c64.png";
}