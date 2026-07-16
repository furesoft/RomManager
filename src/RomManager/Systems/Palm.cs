using RomManager.Models;

namespace RomManager.Systems;

public class Palm : SystemInfo
{
    public override string Name { get; } = "Palm OS";
    public override string Path { get; } = "palm";
    public override string[] Extensions { get; } = { ".prc", ".pdb", ".pqa", ".zip" };
    public override string IconName { get; } = "palm.png";
}