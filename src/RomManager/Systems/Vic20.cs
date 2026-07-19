using RomManager.Models;

namespace RomManager.Systems;

public class Vic20 : SystemInfo
{
    public override string Name => "Commodore VIC-20";
    public override string Path => "vic20";
    public override string[] Extensions { get; } = [".prg", ".crt", ".d64", ".t64", ".tap", ".p00", ".zip"];
    public override string? IconName => null;
}