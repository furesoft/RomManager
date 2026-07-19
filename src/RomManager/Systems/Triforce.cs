using RomManager.Models;

namespace RomManager.Systems;

public class Triforce : SystemInfo
{
    public override string Name => "Sega Nintendo Namco Triforce";
    public override string Path => "triforce";
    public override string[] Extensions { get; } = [".iso", ".gcm", ".bin", ".dat", ".zip"];
    public override string? IconName => null;
}