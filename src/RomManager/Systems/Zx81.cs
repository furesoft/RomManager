using RomManager.Models;

namespace RomManager.Systems;

public class Zx81 : SystemInfo
{
    public override string Name { get; } = "Sinclair ZX81";
    public override string Path { get; } = "zx81";
    public override string[] Extensions { get; } = [".p", ".81", ".t81", ".tzx", ".zip"];
    public override string IconName { get; } = "zxs.png";
}