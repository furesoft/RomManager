using System.Collections.Generic;
using System.Linq;
using Avalonia.Platform.Storage;
using RomManager.Models;

namespace RomManager.Core;

public class FilenameFilterBuilder(RomManager romManager)
{
    private FilePickerFileType[]? _filter;

    public FilePickerFileType[] GetFilter()
    {
        if (_filter != null) return _filter;

        var filterLines = new List<FilePickerFileType>();

        var allExtensions = romManager.Systems
            .SelectMany(s => s.Extensions)
            .Select(EnsureWildcard)
            .Distinct();

        if (allExtensions.Any())
        {
            filterLines.Add(new FilePickerFileType("All Supported ROMs") { Patterns = allExtensions.ToArray() });
        }

        foreach (var system in romManager.Systems)
        {
            if (!system.Extensions.Any())
                continue;

            var patterns = system.Extensions.Select(EnsureWildcard);

            filterLines.Add(new FilePickerFileType(system.Name) { Patterns = patterns.ToArray() });
        }

        _filter = filterLines.ToArray();
        return _filter;
    }

    private static string EnsureWildcard(string ext)
    {
        if (string.IsNullOrWhiteSpace(ext)) return "*.*";

        var cleanExt = ext.StartsWith('.') ? ext : $".{ext}";
        return $"*{cleanExt}";
    }
}
