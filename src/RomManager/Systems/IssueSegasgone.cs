using RomManager.Models;

namespace RomManager.Systems;

public class IssueSegasgone: SystemInfo
{
    public override string Name { get; } = "Sega Computer Videogame SG-1000";
    public override string Path { get; } = "segasgone";
    public override string[] Extensions { get; } = [".sg", ".bin", ".rom", ".mv", ".zip", ".7z"];
    public override string IconName { get; } = "segasgone.png";
}