using RomManager.Models;

namespace RomManager.Systems;

public class Wasm4 : SystemInfo
{
    public override string Name { get; } = "WASM-4";
    public override string Path { get; } = "wasm4";
    public override string[] Extensions { get; } = { ".wasm" };
    public override string? IconName { get; } = null;
    
}