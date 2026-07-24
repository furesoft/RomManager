using RomManager.Models;

namespace RomManager.Systems;

public class Genesis : SystemInfo
{
    public override string Name => "Sega Genesis";
    public override string Path => "genesis";
    public override string[] Extensions { get; } = [".md", ".smd", ".gen", ".zip"];
    public override string? IconName => null;
}
