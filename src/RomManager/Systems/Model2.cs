using RomManager.Models;

namespace RomManager.Systems;

public class Model2 : SystemInfo
{
    public override string Name { get; } = "Sega Model 2";
    public override string Path { get; } = "model2";
    public override string[] Extensions { get; } = { ".zip", ".7z" };
    public override string? IconName { get; } = null;
}