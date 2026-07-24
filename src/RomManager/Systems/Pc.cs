using RomManager.Models;

namespace RomManager.Systems;

public class Pc : SystemInfo
{
    public override string Name => "PC";
    public override string Path => "pc";
    public override string[] Extensions { get; } = [".exe", ".com", ".bat", ".dos", ".conf", ".sh", ".zip"];
    public override string? IconName => null;
}
