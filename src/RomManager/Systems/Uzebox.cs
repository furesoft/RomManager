using RomManager.Models;

namespace RomManager.Systems;

public class Uzebox : SystemInfo
{
    public override string Name => "Uzebox";
    public override string Path => "uzebox";
    public override string[] Extensions { get; } = [".uzb", ".bin", ".zip"];
    public override string? IconName => null;
}
