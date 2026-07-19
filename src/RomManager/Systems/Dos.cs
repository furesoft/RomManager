using RomManager.Models;

namespace RomManager.Systems;

public class Dos: SystemInfo
{
    public override string Name { get; } = "DOS";
    public override string Path { get; } = "dos";
    public override string[] Extensions { get; } = [".exe", ".com", ".bat", ".conf", ".zip"];
    public override string IconName { get; } = "dos.png";
}