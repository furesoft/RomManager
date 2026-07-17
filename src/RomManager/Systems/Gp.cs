using RomManager.Models;

namespace RomManager.Systems;

public class Gp: SystemInfo
{
    public override string Name { get; } = "GamePark GP32";
    public override string Path { get; } = "gp";
    public override string[] Extensions { get; } = { ".smc", ".fxe", ".gxb", ".zip", ".7z" };
    public override string? IconName { get; } = null;
}