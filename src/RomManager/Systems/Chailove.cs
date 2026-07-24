using RomManager.Models;

namespace RomManager.Systems;

public class Chailove : SystemInfo
{
    public override string Name => "Chai";
    public override string Path => "chai";
    public override string[] Extensions { get; } = [".chai", ".chailove", ".zip"];
    public override string IconName => "chai.png";
}
