using RomManager.Models;

namespace RomManager.Systems;

public class Atomiswave : SystemInfo
{
    public override string Name { get; } = "Sammy Atomiswave";
    public override string Path { get; } = "atomiswave";
    public override string[] Extensions { get; } = [".zip", ".7z", ".chd"];
    public override string? IconName { get; } = null;
}