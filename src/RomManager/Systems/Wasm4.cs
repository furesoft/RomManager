using RomManager.Models;

namespace RomManager.Systems;

public class Wasm4 : SystemInfo
{
    public override string Name => "WASM-4";
    public override string Path => "wasm4";
    public override string[] Extensions { get; } = [".wasm"];
    public override string? IconName => null;
}
