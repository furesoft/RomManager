using RomManager.Models;

namespace RomManager.Systems;

public class Archimedes : SystemInfo
{
    public override string Name => "Acorn Archimedes";
    public override string Path => "archimedes";
    public override string[] Extensions { get; } = [".adf", ".adf.gz", ".arc", ".zip"];
    public override string? IconName => null;
}
