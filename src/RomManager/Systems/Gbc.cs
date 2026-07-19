using RomManager.Models;

namespace RomManager.Systems;

public class Gbc : SystemInfo
{
    public override string Name => "GameBoy Color";
    public override string Path => "GBC";
    public override string[] Extensions { get; } = [".gb", ".gbc", ".zip"];
    public override string IconName => "gbc.png";
}
