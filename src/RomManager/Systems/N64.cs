using RomManager.Models;

namespace RomManager.Systems;

public class N64 : SystemInfo
{
    public override string Name { get; } = "Nintendo 64";
    public override string Path { get; } = "n64";
    public override string[] Extensions { get; } = { ".n64", ".z64", ".v64" };
    public override string IconName { get; } = "n64.ico";
}