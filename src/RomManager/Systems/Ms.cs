using RomManager.Models;

namespace RomManager.Systems;

public class Ms: SystemInfo
{
    public override string Name { get; } = "Sega Master System";
    public override string Path { get; } = "ms";
    public override string[] Extensions { get; } = { ".sms", ".bin", ".zip", ".7z" };
    public override string IconName { get; } = "ms.png";
}