using RomManager.Models;

namespace RomManager.Systems;

public class Sgfx: SystemInfo
{
    public override string Name { get; } = "SuperGrafx";
    public override string Path { get; } = "sgfx";
    public override string[] Extensions { get; } = { ".pce", ".sgx", ".bin", ".zip", ".7z" };
    public override string IconName { get; } = "sgfx.png";
}