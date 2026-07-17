using RomManager.Models;

namespace RomManager.Systems;

public class Pc : SystemInfo
{
    public override string Name { get; } = "PC";
    public override string Path { get; } = "pc";
    public override string[] Extensions { get; } = { ".exe", ".com", ".bat", ".dos", ".conf", ".sh", ".zip" };
    public override string? IconName { get; } = null;
}