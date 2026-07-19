using RomManager.Models;

namespace RomManager.Systems;

public class issueFairchild: SystemInfo
{
    public override string Name => "Fairchild Channel F";
    public override string Path => "fairchild";
    public override string[] Extensions { get; } = [".bin", ".rom", ".chf", ".zip", ".7z"];
    public override string? IconName => null;
}