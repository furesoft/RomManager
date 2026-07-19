using RomManager.Models;

namespace RomManager.Systems;

public class Supergrafx : SystemInfo
{
    public override string Name { get; } = "NEC SuperGrafx";
    public override string Path { get; } = "supergrafx";
    public override string[] Extensions { get; } = [".pce", ".sgx", ".bin", ".zip"];
    public override string? IconName { get; } = null;
}