using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace RomManager.Core.RegionDetection;

public abstract class RegionDetector : IRegionDetector
{
    private readonly FilenameRegionDetector _filenameDetector = new();

    public virtual bool CanDetect(string filePath)
    {
        return File.Exists(filePath);
    }

    public virtual Region[] Detect(string filePath)
    {
        if (!CanDetect(filePath)) return [];

        // Try system-specific detection first (implemented by subclasses)
        var systemSpecificRegions = DetectSystemSpecific(filePath);
        if (systemSpecificRegions.Length > 0) return systemSpecificRegions;

        // Fallback to filename pattern detection
        return _filenameDetector.Detect(filePath);
    }

    /// <summary>
    ///     System-specific region detection (e.g., from ROM header).
    ///     Override this in subclasses for specific systems.
    ///     Returns empty array if not detected via this method.
    /// </summary>
    protected virtual Region[] DetectSystemSpecific(string filePath)
    {
        return [];
    }

    protected static Region[] MergeRegions(params Region[][] regionArrays)
    {
        var merged = new HashSet<Region>();
        foreach (var regions in regionArrays)
        foreach (var region in regions)
            if (region != Region.Unknown)
                merged.Add(region);

        return merged.Any() ? merged.OrderBy(r => r).ToArray() : [Region.Unknown];
    }
}
