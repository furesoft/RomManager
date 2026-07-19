using RomManager.Models;

namespace RomManager.Systems;

public class Xbox : SystemInfo
{
    public override string Name => "Microsoft Xbox";
    public override string Path => "xbox";
    public override string[] Extensions { get; } = [".iso", ".xbe", ".cci", ".zip"];
    public override string? IconName => null;
}