using RomManager.Models;

namespace RomManager.Systems;

public class Consolearcade : SystemInfo
{
    public override string Name { get; } = "Console Arcade";
    public override string Path { get; } = "consolearcade";
    public override string[] Extensions { get; } = { ".lnk", ".bat", ".exe", ".cmd", ".zip" };
    public override string? IconName { get; } = null;
    
}