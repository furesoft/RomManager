using RomManager.Models;

namespace RomManager.Systems;

public class Gameandwatch : SystemInfo
{
    public override string Name => "Nintendo Game & Watch";
    public override string Path => "gameandwatch";
    public override string[] Extensions { get; } = [".mgw", ".zip"];
    public override string? IconName => null;
}