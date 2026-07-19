using RomManager.Models;

namespace RomManager.Systems;

public class Intellivision : SystemInfo
{
    public override string Name => "Mattel Intellivision";
    public override string Path => "intellivision";
    public override string[] Extensions { get; } = [".int", ".bin", ".rom", ".zip"];
    public override string? IconName => null;
}