using RomManager.Models;

namespace RomManager.Systems;

public class Lutro : SystemInfo
{
    public override string Name => "Lutro";
    public override string Path => "lutro";
    public override string[] Extensions { get; } = [".lutro", ".lua", ".zip"];
    public override string? IconName => null;
}