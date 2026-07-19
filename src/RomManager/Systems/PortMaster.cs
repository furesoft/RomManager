using RomManager.Models;

namespace RomManager.Systems;

public class PortMaster: SystemInfo
{
    public override string Name { get; } = "Linux Ports";
    public override string Path { get; } = "ports";
    public override string[] Extensions { get; } = [".sh", ".sh.txt", ".port", ".zip"];
    public override string IconName { get; } = "ports.png";
}