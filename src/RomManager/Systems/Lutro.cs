using RomManager.Models;

namespace RomManager.Systems;

public class Lutro : SystemInfo
{
    public override string Name { get; } = "Lutro";
    public override string Path { get; } = "lutro";
    public override string[] Extensions { get; } = { ".lutro", ".lua", ".zip" };
    public override string? IconName { get; } = null;
}