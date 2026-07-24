using RomManager.Models;

namespace RomManager.Systems;

public class Amigacd32 : SystemInfo
{
    public override string Name => "Commodore Amiga CD32";
    public override string Path => "amigacd32";
    public override string[] Extensions { get; } = [".cue", ".iso", ".chd", ".bin", ".wav", ".zip"];
    public override string IconName => "amiga.png";
}
