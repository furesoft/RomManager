using RomManager.Models;

namespace RomManager.Systems;

public class Easyrpg: SystemInfo
{
    public override string Name { get; } = "EasyRPG";
    public override string Path { get; } = "easyrpg";
    public override string[] Extensions { get; } = { ".easyrpg", ".ini", ".exe", ".zip" };
    public override string IconName { get; } = "easyrpg.png";
}