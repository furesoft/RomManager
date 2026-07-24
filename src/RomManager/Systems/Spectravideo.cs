using RomManager.Models;

namespace RomManager.Systems;

public class Spectravideo : SystemInfo
{
    public override string Name => "Spectravideo";
    public override string Path => "spectravideo";
    public override string[] Extensions { get; } = [".cas", ".wav", ".dsk", ".rom", ".zip"];
    public override string? IconName => null;
}
