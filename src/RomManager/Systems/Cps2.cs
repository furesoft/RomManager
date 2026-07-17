using RomManager.Models;

namespace RomManager.Systems;
public class Cps2: SystemInfo
{
    public override string Name { get; } = "Capcom Play System 2";
    public override string Path { get; } = "cps1";
    public override string[] Extensions { get; } = { ".zip", ".7z" };
    public override string IconName { get; } = "cps2.png";
}