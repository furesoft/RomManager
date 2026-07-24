using RomManager.Models;

namespace RomManager.Systems;

public class Plus4 : SystemInfo
{
    public override string Name => "Commodore Plus/4";
    public override string Path => "plus4";
    public override string[] Extensions { get; } = [".d64", ".prg", ".t64", ".tap", ".p00", ".crt", ".zip"];
    public override string? IconName => null;
}
