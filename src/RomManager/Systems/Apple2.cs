using RomManager.Models;

namespace RomManager.Systems;

public class Apple2 : SystemInfo
{
    public override string Name => "Apple II";
    public override string Path => "apple2";
    public override string[] Extensions { get; } = [".dsk", ".do", ".po", ".nib", ".2mg", ".hdv", ".woz", ".zip"];
    public override string? IconName => null;
}