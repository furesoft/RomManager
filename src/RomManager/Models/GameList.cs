using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using RomManager.Configurations;
using RomManager.Hosting;

namespace RomManager.Models;

[XmlRoot("gameList")]
public class GameList
{
    [XmlElement("game")]
    public List<GameInfo> Games { get; set; } = [];

    [XmlIgnore]
    public Dictionary<string, GameInfo> GamesByFilename { get; set; } = new();

    public static GameList ReadFromFile(SystemInfo system)
    {
        var path = GetPath(system);

        if (!File.Exists(path))
        {
            return new();
        }

        var serializer = new XmlSerializer(typeof(GameList));
        using var reader = new StreamReader(path);

        return (GameList)serializer.Deserialize(reader)!;
    }

    public void WriteToFile(SystemInfo system)
    {
        var path = GetPath(system);
        var serializer = new XmlSerializer(typeof(GameList));
        using var writer = new StreamWriter(path);

        serializer.Serialize(writer, this);

        writer.Flush();
        writer.Close();
    }

    public static string GetPath(SystemInfo system)
    {
        var configuration = AppHost.Services.GetRequiredService<IOptions<PathsConfiguration>>().Value;
        var path = Path.Combine(configuration.BasePath, "ES-DE", "gamelists", system.Path, "gamelist.xml");

        return path;
    }
}
