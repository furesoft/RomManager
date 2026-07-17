using RomManager.Models;

namespace RomManager.Systems;

public class Uzebox : SystemInfo
{
    public override string Name { get; } = "Uzebox";
    public override string Path { get; } = "uzebox";
    public override string[] Extensions { get; } = { ".uzb", ".bin", ".zip" };
    public override string? IconName { get; } = null;
}