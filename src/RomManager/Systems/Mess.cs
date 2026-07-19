using RomManager.Models;

namespace RomManager.Systems;

public class Mess : SystemInfo
{
    public override string Name { get; } = "MESS";
    public override string Path { get; } = "mess";
    public override string[] Extensions { get; } = [".zip", ".7z", ".chd", ".cmd"];
    public override string? IconName { get; } = null;
}