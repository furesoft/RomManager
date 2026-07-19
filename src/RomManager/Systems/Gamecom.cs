using RomManager.Models;

namespace RomManager.Systems;

public class Gamecom : SystemInfo
{
    public override string Name => "Game.com";
    public override string Path => "gamecom";
    public override string[] Extensions { get; } = [".bin", ".tgc"];
    public override string? IconName => null;
}