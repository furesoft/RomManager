using RomManager.Models;

namespace RomManager.Systems;

public class Genesis : SystemInfo
{
    public override string Name { get; } = "Sega Genesis";
    public override string Path { get; } = "genesis";
    public override string[] Extensions { get; } = [".md", ".smd", ".gen", ".zip"];
    public override string? IconName { get; } = null;
}