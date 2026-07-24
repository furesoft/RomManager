using RomManager.Models;

namespace RomManager.Systems;

public class Tic80 : SystemInfo
{
    public override string Name => "TIC-80";
    public override string Path => "tic80";
    public override string[] Extensions { get; } = [".tic", ".zip"];
    public override string? IconName => null;
}
