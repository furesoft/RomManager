using RomManager.Models;

namespace RomManager.Systems;

public class Consolearcade : SystemInfo
{
    public override string Name => "Console Arcade";
    public override string Path => "consolearcade";
    public override string[] Extensions { get; } = [".lnk", ".bat", ".exe", ".cmd", ".zip"];
    public override string? IconName => null;
}