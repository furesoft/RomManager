using RomManager.Models;

namespace RomManager.Systems;

public class Amiga : SystemInfo
{
    public override string Name { get; } = "Amiga";
    public override string Path { get; } = "amiga";
    public override string[] Extensions { get; } = { ".adf", ".lha", ".ipf", ".zip" };
    public override string IconName { get; } = "amiga.png";
}