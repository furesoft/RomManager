using RomManager.Models;

namespace RomManager.Systems;

public class Gw : SystemInfo
{
    public override string Name => "Nintendo Game & Watch";
    public override string Path => "gw";
    public override string[] Extensions { get; } = [".mgw", ".zip", ".7z"];
    public override string IconName => "gw.png";
}
