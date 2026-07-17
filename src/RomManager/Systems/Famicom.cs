using RomManager.Models;

namespace RomManager.Systems;

public class Famicom : SystemInfo
{
    public override string Name { get; } = "Nintendo Famicom";
    public override string Path { get; } = "famicom";
    public override string[] Extensions { get; } = { ".nes", ".fds", ".bin", ".zip", ".7z" };
    public override string? IconName { get; } = null;
    
}