using RomManager.Models;

namespace RomManager.Systems;

public class Pcenginecd : SystemInfo
{
    public override string Name { get; } = "NEC PC Engine CD-ROM²";
    public override string Path { get; } = "pcenginecd";
    public override string[] Extensions { get; } = [".cue", ".chd", ".iso", ".toc", ".bin", ".zip"];
    public override string IconName { get; } = "pcecd.png";
}