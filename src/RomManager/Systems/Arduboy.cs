using RomManager.Models;

namespace RomManager.Systems;

public class Arduboy : SystemInfo
{
    public override string Name => "Arduboy";
    public override string Path => "arduboy";
    public override string[] Extensions { get; } = [".hex", ".arduboy", ".zip"];
    public override string IconName => "arduboy.png";
}
