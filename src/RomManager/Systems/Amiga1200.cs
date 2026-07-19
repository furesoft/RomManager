using RomManager.Models;

namespace RomManager.Systems;

public class Amiga1200 : SystemInfo
{
    public override string Name { get; } = "Commodore Amiga 1200";
    public override string Path { get; } = "amiga1200";
    public override string[] Extensions { get; } = [".adf", ".ipf", ".dms", ".lha", ".hdf", ".m3u", ".zip"];
    public override string IconName { get; } = "amiga.png";
}