using RomManager.Models;

namespace RomManager.Systems;

public class Apple2gs : SystemInfo
{
    public override string Name { get; } = "Apple IIGS";
    public override string Path { get; } = "apple2gs";
    public override string[] Extensions { get; } = [".2mg", ".hdv", ".dsk", ".po", ".woz", ".zip"];
    public override string IconName { get; } = "apple2gs.png";
}