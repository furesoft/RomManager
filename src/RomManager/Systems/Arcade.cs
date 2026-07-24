using RomManager.Models;

namespace RomManager.Systems;

public class Arcade : SystemInfo
{
    public override string Name => "Arcade";
    public override string Path => "arcade";
    public override string[] Extensions { get; } = [".zip"];
    public override string IconName => "arcade.png";
}
