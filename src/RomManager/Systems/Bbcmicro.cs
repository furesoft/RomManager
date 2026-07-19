using RomManager.Models;

namespace RomManager.Systems;

public class Bbcmicro : SystemInfo
{
    public override string Name { get; } = "BBC Micro";
    public override string Path { get; } = "bbcmicro";
    public override string[] Extensions { get; } = [".ssd", ".dsd", ".ssd.gz", ".dsd.gz", ".inf", ".zip"];
    public override string? IconName { get; } = null;
}