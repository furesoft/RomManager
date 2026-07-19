using RomManager.Models;

namespace RomManager.Systems;

public class PortMaster: SystemInfo
{
    public override string Name => "Linux Ports";
    public override string Path => "ports";
    public override string[] Extensions { get; } = [".sh", ".sh.txt", ".port", ".zip"];
    public override string IconName => "ports.png";
}