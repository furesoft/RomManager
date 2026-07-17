using RomManager.Models;

namespace RomManager.Systems;

public class Windows : SystemInfo
{
    public override string Name { get; } = "Microsoft Windows";
    public override string Path { get; } = "windows";
    public override string[] Extensions { get; } = { ".exe", ".lnk", ".bat", ".url", ".cmd", ".zip" };
    public override string? IconName { get; } = null;
}