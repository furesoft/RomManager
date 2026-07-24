using RomManager.Models;

namespace RomManager.Systems;

public class Lowresnx : SystemInfo
{
    public override string Name => "LowRes NX";
    public override string Path => "lowresnx";
    public override string[] Extensions { get; } = [".nx", ".zip"];
    public override string? IconName => null;
}
