using RomManager.Models;

namespace RomManager.Systems;

public class Gamegear : SystemInfo
{
    public override string Name => "Game Gear";
    public override string Path => "gamegear";
    public override string[] Extensions { get; } = [".gg", ".zip"];
    public override string? IconName => null;
}