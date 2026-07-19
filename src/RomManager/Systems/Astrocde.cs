using RomManager.Models;

namespace RomManager.Systems;

public class Astrocde : SystemInfo
{
    public override string Name => "Bally Astrocade";
    public override string Path => "astrocde";
    public override string[] Extensions { get; } = [".bin", ".rom", ".zip"];
    public override string? IconName => null;
}