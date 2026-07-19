using RomManager.Models;

namespace RomManager.Systems;

public class Wsc: SystemInfo
{
    public override string Name { get; } = "Bandai WonderSwan Color";
    public override string Path { get; } = "wsc";
    public override string[] Extensions { get; } = [".wsc", ".ws", ".bin", ".zip", ".7z"];
    public override string IconName { get; } = "wsc.png";
}