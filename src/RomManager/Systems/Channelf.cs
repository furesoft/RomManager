using RomManager.Models;

namespace RomManager.Systems;

public class Channelf : SystemInfo
{
    public override string Name => "Fairchild Channel F";
    public override string Path => "channelf";
    public override string[] Extensions { get; } = [".bin", ".chf", ".rom", ".zip", ".7z"];
    public override string? IconName => null;
}
