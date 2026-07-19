using RomManager.Models;

namespace RomManager.Systems;

public class Amstradcpc : SystemInfo
{
    public override string Name => "Amstrad PC";
    public override string Path => "amstradpc";
    public override string[] Extensions { get; } = [".dsk", ".img", ".exe", ".com", ".bat", ".zip"];
    public override string IconName => "cpc.png";
}