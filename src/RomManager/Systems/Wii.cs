using RomManager.Models;

namespace RomManager.Systems;

public class Wii : SystemInfo
{
    public override string Name { get; } = "Nintendo Wii";
    public override string Path { get; } = "wii";
    public override string[] Extensions { get; } = { ".wbfs", ".iso", ".rvz", ".gcm", ".wia", ".ciso", ".zip" };
    public override string? IconName { get; } = null;
    
}