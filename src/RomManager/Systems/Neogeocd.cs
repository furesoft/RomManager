using RomManager.Models;

namespace RomManager.Systems;

public class Neogeocd: SystemInfo
{
    public override string Name { get; } = "SNK Neo Geo CD";
    public override string Path { get; } = "neocd";
    public override string[] Extensions { get; } = { ".cue", ".iso", ".chd", ".sub", ".zip" };
    public override string IconName { get; } = "neocd.png";
}