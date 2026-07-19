using RomManager.Models;

namespace RomManager.Systems;

public class Wiiu : SystemInfo
{
    public override string Name { get; } = "Nintendo Wii U";
    public override string Path { get; } = "wiiu";
    public override string[] Extensions { get; } = [".wua", ".rpx", ".wud", ".wux", ".xml"];
    public override string? IconName { get; } = null;
}