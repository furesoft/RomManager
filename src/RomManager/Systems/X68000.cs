using RomManager.Models;

namespace RomManager.Systems;

public class X68000 : SystemInfo
{
    public override string Name { get; } = "Sharp X68000";
    public override string Path { get; } = "x68000";
    public override string[] Extensions { get; } = { ".dim", ".img", ".d88", ".hdm", ".xdf", ".hdf", ".m3u", ".zip" };
    public override string IconName { get; } = "x68000.png";
}