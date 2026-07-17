using RomManager.Models;

namespace RomManager.Systems;

public class Switch : SystemInfo
{
    public override string Name { get; } = "Nintendo Switch";
    public override string Path { get; } = "switch";
    public override string[] Extensions { get; } = { ".nsp", ".xci", ".pfs0", ".nro", ".zip" };
    public override string? IconName { get; } = null;
}