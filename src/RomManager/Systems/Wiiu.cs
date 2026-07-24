using RomManager.Models;

namespace RomManager.Systems;

public class Wiiu : SystemInfo
{
    public override string Name => "Nintendo Wii U";
    public override string Path => "wiiu";
    public override string[] Extensions { get; } = [".wua", ".rpx", ".wud", ".wux", ".xml"];
    public override string? IconName => null;
}
