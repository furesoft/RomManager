using RomManager.Models;

namespace RomManager.Systems;

public class Msu1 : SystemInfo
{
    public override string Name => "Super Nintendo MSU-1";
    public override string Path => "msu1";
    public override string[] Extensions { get; } = [".sfc", ".smc", ".msu", ".m3u", ".zip"];
    public override string IconName => "msu1.png";
}