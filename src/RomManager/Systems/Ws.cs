using RomManager.Models;

namespace RomManager.Systems;

public class Ws: SystemInfo
{
    public override string Name => "Bandai WonderSwan";
    public override string Path => "ws";
    public override string[] Extensions { get; } = [".ws", ".wsc", ".bin", ".zip", ".7z"];
    public override string IconName => "ws.png";
}