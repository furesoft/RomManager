using RomManager.Models;

namespace RomManager.Systems;

public class Palm : SystemInfo
{
    public override string Name => "Palm OS";
    public override string Path => "palm";
    public override string[] Extensions { get; } = [".prc", ".pdb", ".pqa", ".zip"];
    public override string? IconName => null;
}