using RomManager.Models;

namespace RomManager.Systems;

public class Chailove: SystemInfo
{
    public override string Name { get; } = "Chai";
    public override string Path { get; } = "chai";
    public override string[] Extensions { get; } = {".chai", ".chailove",".zip" };
    public override string IconName { get; } = "c64.png";
}