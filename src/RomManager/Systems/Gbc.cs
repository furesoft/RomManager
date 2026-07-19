using RomManager.Models;

namespace RomManager.Systems;

public class Gbc : SystemInfo
{
    public override string Name { get; } = "GameBoy Color";
    public override string Path { get; } = "GBC";
    public override string[] Extensions { get; } = [".gbc", ".zip"];
    public override string IconName { get; } = "GBC.png";
}