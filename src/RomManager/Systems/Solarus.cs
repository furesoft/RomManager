using RomManager.Models;

namespace RomManager.Systems;

public class Solarus : SystemInfo
{
    public override string Name => "Solarus";
    public override string Path => "solarus";
    public override string[] Extensions { get; } = [".solarus", ".zip"];
    public override string? IconName => null;
}
