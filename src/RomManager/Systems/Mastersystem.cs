using RomManager.Models;

namespace RomManager.Systems;

public class Mastersystem : SystemInfo
{
    public override string Name => "Sega Master System";
    public override string Path => "mastersystem";
    public override string[] Extensions { get; } = [".sms", ".bin", ".zip"];
    public override string? IconName => null;
}