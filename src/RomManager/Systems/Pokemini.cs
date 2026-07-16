using RomManager.Models;

namespace RomManager.Systems;

public class Pokemini : SystemInfo
{
    public override string Name { get; } = "Nintendo Pokémon Mini";
    public override string Path { get; } = "pokemini";
    public override string[] Extensions { get; } = { ".min", ".zip" };
    public override string IconName { get; } = "poke.png";
}