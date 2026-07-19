using RomManager.Models;

namespace RomManager.Systems;

public class Wonderswan : SystemInfo
{
    public override string Name => "Bandai WonderSwan";
    public override string Path => "wonderswan";
    public override string[] Extensions { get; } = [".ws", ".bin", ".zip", ".7z"];
    public override string? IconName => null;
}