using RomManager.Models;

namespace RomManager.Systems;

public class Fbneo : SystemInfo
{
    public override string Name => "FinalBurn Neo";
    public override string Path => "fbneo";
    public override string[] Extensions { get; } = [".zip", ".7z", ".chd"];
    public override string? IconName => null;
}
