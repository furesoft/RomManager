using RomManager.Models;

namespace RomManager.Systems;

public class Windows3x : SystemInfo
{
    public override string Name { get; } = "Microsoft Windows 3.x";
    public override string Path { get; } = "windows3x";
    public override string[] Extensions { get; } = [".exe", ".bat", ".com", ".conf", ".zip"];
    public override string? IconName { get; } = null;
}