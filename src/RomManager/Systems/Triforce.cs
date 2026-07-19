using RomManager.Models;

namespace RomManager.Systems;

public class Triforce : SystemInfo
{
    public override string Name { get; } = "Sega Nintendo Namco Triforce";
    public override string Path { get; } = "triforce";
    public override string[] Extensions { get; } = [".iso", ".gcm", ".bin", ".dat", ".zip"];
    public override string? IconName { get; } = null;
}