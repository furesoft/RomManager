using RomManager.Models;

namespace RomManager.Systems;

public class Easyrpg : SystemInfo
{
    public override string Name => "EasyRPG";
    public override string Path => "easyrpg";
    public override string[] Extensions { get; } = [".easyrpg", ".ini", ".exe", ".zip"];
    public override string IconName => "easyrpg.png";
}
