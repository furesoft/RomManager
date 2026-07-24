using RomManager.Models;

namespace RomManager.Systems;

public class Supracan : SystemInfo
{
    public override string Name => "Super A'Can";
    public override string Path => "supracan";
    public override string[] Extensions { get; } = [".can", ".bin", ".zip"];
    public override string? IconName => null;
}
