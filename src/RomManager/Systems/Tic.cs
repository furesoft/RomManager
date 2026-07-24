using RomManager.Models;

namespace RomManager.Systems;

public class Tic : SystemInfo
{
    public override string Name => "TIC-80 Virtual Computer";
    public override string Path => "tic";
    public override string[] Extensions { get; } = [".tic", ".zip", ".7z"];
    public override string IconName => "tic.png";
}
