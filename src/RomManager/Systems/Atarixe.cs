using RomManager.Models;

namespace RomManager.Systems;

public class Atarixe : SystemInfo
{
    public override string Name { get; } = "Atari XE Game System";
    public override string Path { get; } = "atarixe";
    public override string[] Extensions { get; } = { ".xex", ".atr", ".rom", ".bin" };
    public override string? IconName { get; } = null;
}