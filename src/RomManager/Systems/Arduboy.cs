using RomManager.Models;

namespace RomManager.Systems;

public class Arduboy : SystemInfo
{
    public override string Name { get; } = "Arduboy";
    public override string Path { get; } = "arduboy";
    public override string[] Extensions { get; } = [".hex", ".arduboy", ".zip"];
    public override string IconName { get; } = "arduboy.png";
}