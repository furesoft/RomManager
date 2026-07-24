using RomManager.Models;

namespace RomManager.Systems;

public class Amiga : SystemInfo
{
    public override string Name => "Amiga";
    public override string Path => "amiga";
    public override string[] Extensions { get; } = [".adf", ".lha", ".ipf", ".zip"];
    public override string IconName => "amiga.png";
}
