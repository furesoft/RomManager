using RomManager.Models;

namespace RomManager.Systems;

public class Dos: SystemInfo
{
    public override string Name => "DOS";
    public override string Path => "dos";
    public override string[] Extensions { get; } = [".exe", ".com", ".bat", ".conf", ".zip"];
    public override string IconName => "dos.png";
}