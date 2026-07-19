using RomManager.Models;

namespace RomManager.Systems;

public class Amiga600 : SystemInfo
{
    public override string Name { get; } = "Commodore Amiga 600";
    public override string Path { get; } = "amiga600";
    public override string[] Extensions { get; } = [".adf", ".ipf", ".dms", ".lha", ".hdf", ".m3u", ".zip"];
    public override string IconName { get; } = "amiga600.png";
}