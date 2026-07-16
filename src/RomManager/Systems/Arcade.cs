using RomManager.Models;

namespace RomManager.Systems;

public class Arcade : SystemInfo
{
    public override string Name { get; } = "Arcade";
    public override string Path { get; } = "arcade";
    public override string[] Extensions { get; } = { ".zip" };
    public override string IconName { get; } = "arcade.png";
}