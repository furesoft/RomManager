using RomManager.Models;

namespace RomManager.Systems;

public class N64dd : SystemInfo
{
    public override string Name => "Nintendo 64 Disk Drive";
    public override string Path => "n64dd";
    public override string[] Extensions { get; } = [".ndd", ".n64", ".z64", ".zip"];
    public override string? IconName => null;
}
