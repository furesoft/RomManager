using RomManager.Models;

namespace RomManager.Systems;

public class Scv : SystemInfo
{
    public override string Name { get; } = "Epoch Super Cassette Vision";
    public override string Path { get; } = "scv";
    public override string[] Extensions { get; } = { ".scv", ".bin", ".zip" };
    public override string? IconName { get; } = null;
    
}