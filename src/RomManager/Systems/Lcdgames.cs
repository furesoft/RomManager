using RomManager.Models;

namespace RomManager.Systems;

public class Lcdgames : SystemInfo
{
    public override string Name { get; } = "Handheld LCD Games";
    public override string Path { get; } = "lcdgames";
    public override string[] Extensions { get; } = [".mgw", ".zip", ".7z"];
    public override string? IconName { get; } = null;
}