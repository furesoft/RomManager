using RomManager.Models;

namespace RomManager.Systems;

public class Dc: SystemInfo
{
    public override string Name { get; } = "Doom";
    public override string Path { get; } = "doom";
    public override string[] Extensions { get; } = { ".zip" };
    public override string IconName { get; } = "doom.png";
}