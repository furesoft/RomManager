using RomManager.Models;

namespace RomManager.Systems;

public class Switch : SystemInfo
{
    public override string Name => "Nintendo Switch";
    public override string Path => "switch";
    public override string[] Extensions { get; } = [".nsp", ".xci", ".pfs0", ".nro", ".zip"];
    public override string? IconName => null;
}