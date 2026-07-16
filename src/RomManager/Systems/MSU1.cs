using RomManager.Models;

namespace RomManager.Systems;

public class Msu1: SystemInfo
{
    public override string Name { get; } = "Media Streaming Unit 1";
    public override string Path { get; } = "msu1";
    public override string[] Extensions { get; } = { ".sfc", ".msu", ".pcm", ".zip" };
    public override string IconName { get; } = "msu1.png";
}