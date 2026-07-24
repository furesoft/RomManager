using System;
using System.Globalization;
using System.Xml.Serialization;

namespace RomManager.Models;

public class GameInfo
{
    [XmlElement("path")] public string Path { get; set; }

    [XmlElement("name")] public string Name { get; set; }

    [XmlElement("desc")] public string Description { get; set; }

    [XmlElement("rating")] public double Rating { get; set; }

    // Handled below via a proxy property to parse the specific EmulationStation date format
    [XmlIgnore] public DateTime? ReleaseDate { get; set; }

    [XmlElement("releasedate")]
    public string ReleaseDateString
    {
        get => ReleaseDate?.ToString("yyyyMMddTHHmmss");
        set
        {
            if (DateTime.TryParseExact(value, "yyyyMMddTHHmmss", null, DateTimeStyles.None, out var date))
                ReleaseDate = date;
            else
                ReleaseDate = null;
        }
    }

    [XmlElement("developer")] public string Developer { get; set; }

    [XmlElement("publisher")] public string Publisher { get; set; }

    [XmlElement("genre")] public string Genre { get; set; }

    [XmlElement("players")] public string Players { get; set; }

    [XmlElement("favorite")] public bool IsFavorite { get; set; }
}
