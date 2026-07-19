using RomManager.Models;

namespace RomManager.Systems;

public class Sgfx: SystemInfo
{
    public override string Name => "SuperGrafx";
    public override string Path => "sgfx";
    public override string[] Extensions { get; } = [".pce", ".sgx", ".bin", ".zip", ".7z"];
    public override string IconName => "sgfx.png";
}