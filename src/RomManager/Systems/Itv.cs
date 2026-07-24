using RomManager.Models;

namespace RomManager.Systems;

public class Itv : SystemInfo
{
    public override string Name => "Mattel Intellivision";
    public override string Path => "intellivision";
    public override string[] Extensions { get; } = [".int", ".bin", ".rom", ".zip", ".7z"];
    public override string IconName => "itv.png";
}
