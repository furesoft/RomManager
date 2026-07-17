using RomManager.Models;

namespace RomManager.Systems;

public class Gmaster : SystemInfo
{
    public override string Name { get; } = "Game Master";
    public override string Path { get; } = "gmaster";
    public override string[] Extensions { get; } = { ".bin" };
    public override string? IconName { get; } = null;
}