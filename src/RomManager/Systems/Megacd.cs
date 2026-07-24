using RomManager.Models;

namespace RomManager.Systems;

public class Megacd : SystemInfo, IHasBios
{
    public override string Name => "Sega Mega-CD";
    public override string Path => "megacd";
    public override string[] Extensions { get; } = [".cue", ".iso", ".chd", ".bin", ".zip"];
    public override string? IconName => null;
    public string[] BiosFiles { get; } = ["bios_CD_E.bin", "bios_CD_U.bin", "bios_CD_J.bin"];
}
