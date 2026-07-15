using RomManager.Models;

namespace RomManager.Systems;

public class GBA : SystemInfo
{
    public override string Name { get; } = "GameBoy Advanced";
    public override string Path { get; } = "GBA";
    public override string[] Extensions { get; } = {".gba", ".zip" };
    public override string IconName { get; } = "GBA.png";
}