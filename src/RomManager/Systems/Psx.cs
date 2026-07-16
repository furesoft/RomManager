using RomManager.Models;

namespace RomManager.Systems;

public class Psx: SystemInfo
{
    public override string Name { get; } = "Pokémon Mini";
    public override string Path { get; } = "poke";
    public override string[] Extensions { get; } = { ".min", ".bin", ".zip", ".7z" };
    public override string IconName { get; } = "poke.png";
}