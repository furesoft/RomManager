using RomManager.Models;

namespace RomManager.Systems;

public class Lutris : SystemInfo
{
    public override string Name => "Lutris";
    public override string Path => "lutris";
    public override string[] Extensions { get; } = [".lutris", ".desktop", ".json", ".zip"];
    public override string? IconName => null;
}
