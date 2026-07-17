using RomManager.Models;

namespace RomManager.Systems;

public class Tic80 : SystemInfo
{
    public override string Name { get; } = "TIC-80";
    public override string Path { get; } = "tic80";
    public override string[] Extensions { get; } = { ".tic", ".zip" };
    public override string? IconName { get; } = null;
}