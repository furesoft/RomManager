using System.Collections.Generic;

namespace RomManager.Models;

public sealed class GameCollection
{
    public required string Name { get; init; }
    public required IReadOnlyList<Game> Games { get; init; }
}
