using RomManager.Models;

namespace RomManager.Systems;

public class Adam : SystemInfo
{
    public override string Name { get; } = "Coleco Adam";
    public override string Path { get; } = "adam";
    public override string[] Extensions { get; } = [".ddp", ".dsk", ".rom", ".zip"];
    public override string IconName { get; } = null;
}