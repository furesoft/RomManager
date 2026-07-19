using RomManager.Models;

namespace RomManager.Systems;

public class Gba : SystemInfo
{
    public override string Name => "GameBoy Advanced";
    public override string Path => "GBA";
    public override string[] Extensions { get; } = [".gba", ".zip"];
    public override string IconName => "GBA.png";
}