using RomManager.Models;

namespace RomManager.Systems;

public class Zxc : SystemInfo
{
    public override string Name { get; } = "ZX Spectrum clones";
    public override string Path { get; } = "zxc";
    public override string[] Extensions { get; } = { ".tap", ".tzx", ".scl", ".trd", ".z80", ".szx", ".zip" };
    public override string IconName { get; } = "zxc.png";
}