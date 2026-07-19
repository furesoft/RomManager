using RomManager.Models;

namespace RomManager.Systems;

public class Col: SystemInfo
{
    public override string Name => "ColecoVision";
    public override string Path => "col";
    public override string[] Extensions { get; } = [".col",".zip"];
    public override string IconName => "col.png";
}