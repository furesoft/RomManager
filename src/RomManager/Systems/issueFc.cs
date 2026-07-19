using RomManager.Models;

namespace RomManager.Systems;

public class issueFc: SystemInfo
{
    public override string Name => "Family Computer";
    public override string Path => "fc";
    public override string[] Extensions { get; } = [".nes", ".fds", ".unf", ".unif", ".zip", ".7z"];
    public override string? IconName => null;
}