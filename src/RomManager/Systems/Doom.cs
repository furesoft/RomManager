using RomManager.Models;

namespace RomManager.Systems;

public class Doom: SystemInfo
{
    public override string Name => "Doom";
    public override string Path => "doom";
    public override string[] Extensions { get; } = [".zip"];
    public override string IconName => "doom.png";
}