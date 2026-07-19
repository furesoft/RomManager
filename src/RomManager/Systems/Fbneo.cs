using RomManager.Models;

namespace RomManager.Systems;

public class Fbneo : SystemInfo
{
    public override string Name { get; } = "FinalBurn Neo";
    public override string Path { get; } = "fbneo";
    public override string[] Extensions { get; } = [".zip", ".7z", ".chd"];
    public override string? IconName { get; } = null;
}