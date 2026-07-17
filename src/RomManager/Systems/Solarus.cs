using RomManager.Models;

namespace RomManager.Systems;

public class Solarus : SystemInfo
{
    public override string Name { get; } = "Solarus";
    public override string Path { get; } = "solarus";
    public override string[] Extensions { get; } = { ".solarus", ".zip" };
    public override string? IconName { get; } = null;
}