using RomManager.Models;

namespace RomManager.Systems;

public class Pcengine: SystemInfo
{
    public override string Name { get; } = "PC Engine";
    public override string Path { get; } = "pcengine";
    public override string[] Extensions { get; } = [".pce", ".bin", ".cue", ".ccd", ".zip", ".7z"];
    public override string IconName { get; } = "pce.png";
}