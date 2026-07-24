using RomManager.Models;

namespace RomManager.Systems;

public class Colecovision : SystemInfo, IHasBios
{
    public override string Name => "ColecoVision";
    public override string Path => "colecovision";
    public override string[] Extensions { get; } = [".col", ".bin", ".rom", ".zip", ".7z"];
    public override string? IconName => null;
    public string[] BiosFiles { get; } = ["coleco.rom"];
}
