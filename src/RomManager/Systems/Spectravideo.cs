using RomManager.Models;

namespace RomManager.Systems;

public class Spectravideo : SystemInfo
{
    public override string Name { get; } = "Spectravideo";
    public override string Path { get; } = "spectravideo";
    public override string[] Extensions { get; } = { ".cas", ".wav", ".dsk", ".rom", ".zip" };
    public override string? IconName { get; } = null;
}