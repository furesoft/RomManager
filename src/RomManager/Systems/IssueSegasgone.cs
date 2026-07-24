using RomManager.Models;

namespace RomManager.Systems;

public class IssueSegasgone : SystemInfo
{
    public override string Name => "Sega Computer Videogame SG-1000";
    public override string Path => "segasgone";
    public override string[] Extensions { get; } = [".sg", ".bin", ".rom", ".mv", ".zip", ".7z"];
    public override string IconName => "segasgone.png";
}
