using System.IO;
using RomManager.Configurations;

namespace RomManager.Models;

public abstract class SystemInfo
{
    public abstract string Name { get; }
    public abstract string Path { get; }
    public abstract string[] Extensions { get; }

    public abstract string IconName { get; }

    public override string ToString()
    {
        return Name;
    }

    public bool IsReachable(PathsConfiguration pathsConfiguration)
    {
        var folderPath = System.IO.Path.Combine(pathsConfiguration.BasePath, Path);
        return Directory.Exists(folderPath);
    }

}