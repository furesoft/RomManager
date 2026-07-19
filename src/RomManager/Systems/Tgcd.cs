using RomManager.Models;

namespace RomManager.Systems;

public class Tgcd : SystemInfo
{
    public override string Name { get; } = "TurboGrafx-CD";
    public override string Path { get; } = "tgcd";
    public override string[] Extensions { get; } = [".cue", ".chd", ".iso", ".toc", ".bin", ".zip"];
    public override string? IconName { get; } = null;
}