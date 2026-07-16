using RomManager.Models;

namespace RomManager.Systems;

public class issueFc: SystemInfo
{
    public override string Name { get; } = "Family Computer";
    public override string Path { get; } = "fc";
    public override string[] Extensions { get; } = { ".nes", ".fds", ".unf", ".unif", ".zip", ".7z" };
    public override string IconName { get; } = "fc.png";
}