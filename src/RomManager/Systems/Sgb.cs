using RomManager.Models;

namespace RomManager.Systems;

public class Sgb: SystemInfo
{
    public override string Name { get; } = "Super Game Boy";
    public override string Path { get; } = "sgb";
    public override string[] Extensions { get; } = { ".gb", ".sgb", ".zip", ".7z" };
    public override string IconName { get; } = "sgb.png";
}