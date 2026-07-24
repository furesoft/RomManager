using RomManager.Models;

namespace RomManager.Systems;

public class Apple2gs : SystemInfo
{
    public override string Name => "Apple IIGS";
    public override string Path => "apple2gs";
    public override string[] Extensions { get; } = [".2mg", ".hdv", ".dsk", ".po", ".woz", ".zip"];
    public override string? IconName => null;
}
