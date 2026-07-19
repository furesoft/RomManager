using RomManager.Models;

namespace RomManager.Systems;

public class Supergrafx : SystemInfo
{
    public override string Name => "NEC SuperGrafx";
    public override string Path => "supergrafx";
    public override string[] Extensions { get; } = [".pce", ".sgx", ".bin", ".zip"];
    public override string? IconName => null;
}