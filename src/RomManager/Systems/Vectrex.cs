using RomManager.Models;

namespace RomManager.Systems;

public class Vectrex: SystemInfo
{
    public override string Name { get; } = "Vectrex";
    public override string Path { get; } = "vectrex";
    public override string[] Extensions { get; } = { ".vec", ".bin", ".gam", ".zip", ".7z" };
    public override string IconName { get; } = "vectrex.png";
}