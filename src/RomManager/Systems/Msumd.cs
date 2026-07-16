using RomManager.Models;

namespace RomManager.Systems;

public class Msumd: SystemInfo
{
    public override string Name { get; } = "Mega Drive Streaming Unit";
    public override string Path { get; } = "msumd";
    public override string[] Extensions { get; } = { ".md", ".cue", ".iso", ".zip", ".7z" };
    public override string IconName { get; } = "msumd.png";
}