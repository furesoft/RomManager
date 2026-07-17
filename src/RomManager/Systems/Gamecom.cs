using RomManager.Models;

namespace RomManager.Systems;

public class Gamecom : SystemInfo
{
    public override string Name { get; } = "Game.com";
    public override string Path { get; } = "gamecom";
    public override string[] Extensions { get; } = { ".bin", ".tgc" };
    public override string? IconName { get; } = null;
}