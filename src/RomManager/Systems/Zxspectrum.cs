using RomManager.Models;

namespace RomManager.Systems;

public class Zxspectrum : SystemInfo
{
    public override string Name { get; } = "ZX Spectrum clones";
    public override string Path { get; } = "zxc";
    public override string[] Extensions { get; } = [".tap", ".tzx", ".scl", ".trd", ".z80", ".szx", ".zip"];
    public override string IconName { get; } = "zxs.png";
}