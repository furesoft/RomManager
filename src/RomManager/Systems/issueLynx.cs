using RomManager.Models;

namespace RomManager.Systems;

public class issueLynx: SystemInfo
{
    public override string Name { get; } = "Atari Lynx";
    public override string Path { get; } = "lynx";
    public override string[] Extensions { get; } = [".lnx", ".lyx", ".zip", ".7z"];
    public override string IconName { get; } = "lynx.png";
}