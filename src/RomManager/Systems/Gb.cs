using RomManager.Models;

namespace RomManager.Systems;

public class Gb : SystemInfo
{
    public override string Name { get; } = "Game Boy";
    public override string Path { get; } = "GB";
    public override string[] Extensions { get; } = { ".gb",".zip" };
    public override string IconName { get; } = "gb.png";
}