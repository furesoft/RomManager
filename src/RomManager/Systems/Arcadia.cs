using RomManager.Models;

namespace RomManager.Systems;

public class Arcadia : SystemInfo
{
    public override string Name => "Emerson Arcadia 2001";
    public override string Path => "arcadia";
    public override string[] Extensions { get; } = [".bin", ".rom", ".zip"];
    public override string? IconName => null;
}
