using RomManager.Models;

namespace RomManager.Systems;
public class Cps1: SystemInfo
{
    public override string Name { get; } = "Capcom Play System 1";
    public override string Path { get; } = "cps1";
    public override string[] Extensions { get; } = [".zip", ".7z"];
    public override string IconName { get; } = "cps1.png";
}