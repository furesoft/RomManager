using RomManager.Models;

namespace RomManager.Systems;

public class Gamegear : SystemInfo
{
    public override string Name { get; } = "Game Gear";
    public override string Path { get; } = "gamegear";
    public override string[] Extensions { get; } = { ".gg", ".zip" };
    public override string? IconName { get; } = null;
}