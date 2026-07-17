using RomManager.Models;

namespace RomManager.Systems;

public class issueFairchild: SystemInfo
{
    public override string Name { get; } = "Fairchild Channel F";
    public override string Path { get; } = "fairchild";
    public override string[] Extensions { get; } = { ".bin", ".rom", ".chf", ".zip", ".7z" };
    public override string? IconName { get; } = null;
    
}