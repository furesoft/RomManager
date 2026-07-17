using RomManager.Models;

namespace RomManager.Systems;

public class Snesna : SystemInfo
{
    public override string Name { get; } = "Super Nintendo Entertainment System North America";
    public override string Path { get; } = "snesna";
    public override string[] Extensions { get; } = { ".sfc", ".smc", ".bin", ".zip", ".7z" };
    public override string? IconName { get; } = null;
}