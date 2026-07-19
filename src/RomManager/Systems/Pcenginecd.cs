using RomManager.Models;

namespace RomManager.Systems;

public class Pcenginecd : SystemInfo
{
    public override string Name => "NEC PC Engine CD-ROM²";
    public override string Path => "pcenginecd";
    public override string[] Extensions { get; } = [".cue", ".chd", ".iso", ".toc", ".bin", ".zip"];
    public override string IconName => "pcecd.png";
}