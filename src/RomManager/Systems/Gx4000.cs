using RomManager.Models;

namespace RomManager.Systems;

public class Gx4000 : SystemInfo
{
    public override string Name { get; } = "Amstrad GX4000";
    public override string Path { get; } = "gx4000";
    public override string[] Extensions { get; } = [".cpr", ".bin", ".zip"];
    public override string? IconName { get; } = null;
}