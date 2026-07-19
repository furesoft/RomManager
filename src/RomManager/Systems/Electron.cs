using RomManager.Models;

namespace RomManager.Systems;

public class Electron : SystemInfo
{
    public override string Name => "Acorn Electron";
    public override string Path => "electron";
    public override string[] Extensions { get; } = [".uef", ".ssd", ".dsd", ".rom", ".zip"];
    public override string? IconName => null;
}