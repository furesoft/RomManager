using RomManager.Models;

namespace RomManager.Systems;
public class J2me : SystemInfo
{
    public override string Name { get; } = "Java 2 Micro Edition";
    public override string Path { get; } = "j2me";
    public override string[] Extensions { get; } = { ".jar", ".jad", ".zip" };
    public override string? IconName { get; } = null;
}