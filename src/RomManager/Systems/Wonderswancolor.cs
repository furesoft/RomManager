using RomManager.Models;

namespace RomManager.Systems;

public class Wonderswancolor : SystemInfo
{
    public override string Name => "Bandai WonderSwan Color";
    public override string Path => "wonderswancolor";
    public override string[] Extensions { get; } = [".wsc", ".ws", ".bin", ".zip", ".7z"];
    public override string? IconName => null;
}