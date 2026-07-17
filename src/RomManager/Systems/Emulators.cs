using RomManager.Models;

namespace RomManager.Systems;

public class Emulators : SystemInfo
{
    public override string Name { get; } = "Emulators Launcher";
    public override string Path { get; } = "emulators";
    public override string[] Extensions { get; } = { ".lnk", ".exe", ".bat", ".sh", ".cmd", ".zip" };
    public override string? IconName { get; } = null;
}