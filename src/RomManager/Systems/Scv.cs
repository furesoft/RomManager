using RomManager.Models;

namespace RomManager.Systems;

public class Scv : SystemInfo
{
    public override string Name => "Epoch Super Cassette Vision";
    public override string Path => "scv";
    public override string[] Extensions { get; } = [".scv", ".bin", ".zip"];
    public override string? IconName => null;
}