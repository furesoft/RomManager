using RomManager.Models;

namespace RomManager.Systems;

public class Tg16 : SystemInfo
{
    public override string Name { get; } = "TurboGrafx-16";
    public override string Path { get; } = "tg16";
    public override string[] Extensions { get; } = { ".pce", ".bin", ".zip" };
    public override string? IconName { get; } = null;
    
}