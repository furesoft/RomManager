using RomManager.Models;

namespace RomManager.Systems;

public class Fds: SystemInfo
{
    public override string Name { get; } = "Famicom Disk System";
    public override string Path { get; } = "fds";
    public override string[] Extensions { get; } = [".fds", ".zip", ".7z"];
    public override string IconName { get; } = "fds.png";
}