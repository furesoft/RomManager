using RomManager.Models;

namespace RomManager.Systems;

public class Pcengine : SystemInfo
{
    public override string Name => "PC Engine";
    public override string Path => "pcengine";
    public override string[] Extensions { get; } = [".pce", ".bin", ".cue", ".ccd", ".zip", ".7z"];
    public override string IconName => "pce.png";
}
