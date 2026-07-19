using RomManager.Models;

namespace RomManager.Systems;

public class Adam : SystemInfo
{
    public override string Name => "Coleco Adam";
    public override string Path => "adam";
    public override string[] Extensions { get; } = [".ddp", ".dsk", ".rom", ".zip"];
    public override string IconName => null;
}