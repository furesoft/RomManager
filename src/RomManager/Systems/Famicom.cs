using RomManager.Models;

namespace RomManager.Systems;

public class Famicom : SystemInfo
{
    public override string Name => "Nintendo Famicom";
    public override string Path => "famicom";
    public override string[] Extensions { get; } = [".nes", ".fds", ".bin", ".zip", ".7z"];
    public override string? IconName => null;
    public string[] BiosFiles { get; }
}
