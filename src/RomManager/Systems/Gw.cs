using RomManager.Models;

namespace RomManager.Systems;

public class Gw: SystemInfo
{
    public override string Name { get; } = "Nintendo Game & Watch";
    public override string Path { get; } = "gw";
    public override string[] Extensions { get; } = [".mgw", ".zip", ".7z"];
    public override string IconName { get; } = "gw.png";
}