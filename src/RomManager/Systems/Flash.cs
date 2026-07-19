using RomManager.Models;

namespace RomManager.Systems;

public class Flash : SystemInfo
{
    public override string Name => "Adobe Flash Player";
    public override string Path => "flash";
    public override string[] Extensions { get; } = [".swf", ".exe", ".zip"];
    public override string? IconName => null;
}