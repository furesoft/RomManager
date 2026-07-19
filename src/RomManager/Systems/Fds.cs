using RomManager.Models;

namespace RomManager.Systems;

public class Fds: SystemInfo
{
    public override string Name => "Famicom Disk System";
    public override string Path => "fds";
    public override string[] Extensions { get; } = [".fds", ".zip", ".7z"];
    public override string IconName => "fds.png";
}