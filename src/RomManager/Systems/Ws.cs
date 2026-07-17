using RomManager.Models;

namespace RomManager.Systems;

public class Ws: SystemInfo
{
    public override string Name { get; } = "Bandai WonderSwan";
    public override string Path { get; } = "ws";
    public override string[] Extensions { get; } = { ".ws", ".wsc", ".bin", ".zip", ".7z" };
    public override string IconName { get; } = "ws.png";
}