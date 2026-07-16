using RomManager.Models;

namespace RomManager.Systems;

public class Zxc: SystemInfo
{
    public override string Name { get; } = "ZX Cosmic";
    public override string Path { get; } = "zxspectrum";
    public override string[] Extensions { get; } = { ".zxc", ".tap", ".tzx", ".zip", ".7z" };
    public override string IconName { get; } = "zxs.png";
}