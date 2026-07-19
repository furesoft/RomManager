using RomManager.Models;

namespace RomManager.Systems;

public class To8 : SystemInfo
{
    public override string Name { get; } = "Thomson TO8";
    public override string Path { get; } = "to8";
    public override string[] Extensions { get; } = [".fd", ".sap", ".k7", ".rom", ".m7", ".zip"];
    public override string? IconName { get; } = null;
}