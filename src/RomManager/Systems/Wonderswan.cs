using RomManager.Models;

namespace RomManager.Systems;

public class Wonderswan : SystemInfo
{
    public override string Name { get; } = "Bandai WonderSwan";
    public override string Path { get; } = "wonderswan";
    public override string[] Extensions { get; } = { ".ws", ".bin", ".zip", ".7z" };
    public override string? IconName { get; } = null;
}