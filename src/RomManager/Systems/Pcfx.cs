using RomManager.Models;

namespace RomManager.Systems;

public class Pcfx : SystemInfo
{
    public override string Name { get; } = "NEC PC-FX";
    public override string Path { get; } = "pcfx";
    public override string[] Extensions { get; } = { ".cue", ".chd", ".ccd", ".toc", ".img", ".bin", ".zip" };
    public override string? IconName { get; } = null;
    
}