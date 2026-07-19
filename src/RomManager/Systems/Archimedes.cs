using RomManager.Models;

namespace RomManager.Systems;

public class Archimedes : SystemInfo
{
    public override string Name { get; } = "Acorn Archimedes";
    public override string Path { get; } = "archimedes";
    public override string[] Extensions { get; } = [".adf", ".adf.gz", ".arc", ".zip"];
    public override string? IconName { get; } = null;
}