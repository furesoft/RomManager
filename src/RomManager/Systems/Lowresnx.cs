using RomManager.Models;

namespace RomManager.Systems;

public class Lowresnx : SystemInfo
{
    public override string Name { get; } = "LowRes NX";
    public override string Path { get; } = "lowresnx";
    public override string[] Extensions { get; } = { ".nx", ".zip" };
    public override string? IconName { get; } = null;
}