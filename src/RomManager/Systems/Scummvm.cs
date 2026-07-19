using RomManager.Models;

namespace RomManager.Systems;

public class Scummvm: SystemInfo
{
    public override string Name => "Script Creation Utility for Maniac Mansion Virtual Machine";
    public override string Path => "scummvm";
    public override string[] Extensions { get; } = [".scummvm", ".ini", ".exe", ".zip"];
    public override string IconName => "scummvm.png";
}