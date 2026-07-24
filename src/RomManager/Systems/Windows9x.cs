using RomManager.Models;

namespace RomManager.Systems;

public class Windows9x : SystemInfo
{
    public override string Name => "Microsoft Windows 9x";
    public override string Path => "windows9x";
    public override string[] Extensions { get; } = [".exe", ".bat", ".lnk", ".iso", ".img", ".vhd", ".zip"];
    public override string? IconName => null;
}
