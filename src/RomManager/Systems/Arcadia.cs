using RomManager.Models;

namespace RomManager.Systems;

public class Arcadia : SystemInfo
{
    public override string Name { get; } = "Emerson Arcadia 2001";
    public override string Path { get; } = "arcadia";
    public override string[] Extensions { get; } = { ".bin", ".rom", ".zip" };
    public override string IconName { get; } = "arcadia.png";
}