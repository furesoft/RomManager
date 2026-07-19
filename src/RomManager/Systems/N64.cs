using RomManager.Models;

namespace RomManager.Systems;

public class N64 : SystemInfo
{
    public override string Name => "Nintendo 64";
    public override string Path => "n64";
    public override string[] Extensions { get; } = [".n64", ".z64", ".v64", ".zip"];
    public override string IconName => "n64.png";
}