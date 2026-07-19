using RomManager.Models;

namespace RomManager.Systems;

public class Amiga600 : SystemInfo
{
    public override string Name => "Commodore Amiga 600";
    public override string Path => "amiga600";
    public override string[] Extensions { get; } = [".adf", ".ipf", ".dms", ".lha", ".hdf", ".m3u", ".zip"];
    public override string IconName => "amiga.png";
}