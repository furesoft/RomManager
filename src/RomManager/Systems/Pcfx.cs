using RomManager.Models;

namespace RomManager.Systems;

public class Pcfx : SystemInfo
{
    public override string Name => "NEC PC-FX";
    public override string Path => "pcfx";
    public override string[] Extensions { get; } = [".cue", ".chd", ".ccd", ".toc", ".img", ".bin", ".zip"];
    public override string? IconName => null;
}
