using RomManager.Models;

namespace RomManager.Systems;

public class Wonderswancolor : SystemInfo
{
    public override string Name { get; } = "Bandai WonderSwan Color";
    public override string Path { get; } = "wonderswancolor";
    public override string[] Extensions { get; } = { ".wsc", ".ws", ".bin", ".zip", ".7z" };
    public override string? IconName { get; } = null;
}