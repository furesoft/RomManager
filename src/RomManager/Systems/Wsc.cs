using RomManager.Models;

namespace RomManager.Systems;

public class Wsc : SystemInfo
{
    public override string Name => "Bandai WonderSwan Color";
    public override string Path => "wsc";
    public override string[] Extensions { get; } = [".wsc", ".ws", ".bin", ".zip", ".7z"];
    public override string IconName => "wsc.png";
}
