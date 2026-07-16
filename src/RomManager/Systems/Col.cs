using RomManager.Models;

namespace RomManager.Systems;

public class Col: SystemInfo
{
    public override string Name { get; } = "ColecoVision";
    public override string Path { get; } = "col";
    public override string[] Extensions { get; } = { ".col",".zip" };
    public override string IconName { get; } = "col.png";
}