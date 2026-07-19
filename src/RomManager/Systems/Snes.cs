using RomManager.Models;

namespace RomManager.Systems;

public class Snes: SystemInfo
{
    public override string Name => "Super Nintendo Entertainment System";
    public override string Path => "snes";
    public override string[] Extensions { get; } = [".sfc", ".smc", ".fig", ".swc", ".zip", ".7z"];
    public override string? IconName => null;
}