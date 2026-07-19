using RomManager.Models;

namespace RomManager.Systems;

public class Sfc: SystemInfo
{
    public override string Name => "Super Famicom";
    public override string Path => "sfc";
    public override string[] Extensions { get; } = [".sfc", ".smc", ".fig", ".swc", ".zip", ".7z"];
    public override string IconName => "sfc.png";
}