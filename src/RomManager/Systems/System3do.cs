using RomManager.Models;

namespace RomManager.Systems;

public class System3do : SystemInfo
{
    public override string Name { get; } = "Panasonic 3DO";
    public override string Path { get; } = "3do";
    public override string[] Extensions { get; } = { ".iso", ".cue", ".chd", ".bin", ".zip" };
    public override string? IconName { get; } = null;
}