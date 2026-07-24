using RomManager.Models;

namespace RomManager.Systems;

public class Pokemini : SystemInfo
{
    public override string Name => "Nintendo Pokémon Mini";
    public override string Path => "pokemini";
    public override string[] Extensions { get; } = [".min", ".zip"];
    public override string IconName => "poke.png";
}
