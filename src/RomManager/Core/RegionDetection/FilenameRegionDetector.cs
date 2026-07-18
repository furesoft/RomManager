using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace RomManager.Core.RegionDetection;

public class FilenameRegionDetector : IRegionDetector
{
    // Pattern definitions for region detection
    private static readonly Dictionary<Region, string[]> RegionPatterns = new()
    {
        { Region.Japan, ["\\[J\\]", "\\(J\\)", "\\(Japan\\)", "\\[JP\\]", "\\(JP\\)"] },
        { Region.USA, ["\\[U\\]", "\\(U\\)", "\\(USA\\)", "\\[US\\]", "\\(US\\)", "\\(United States\\)"] },
        { Region.Europe, ["\\[E\\]", "\\(E\\)", "\\(Europe\\)", "\\(EUR\\)"] },
        { Region.Korea, ["\\[K\\]", "\\(K\\)", "\\(Korea\\)", "\\(KOR\\)"] },
        { Region.Australia, ["\\[A\\]", "\\(A\\)", "\\(Australia\\)", "\\(AUS\\)"] },
        { Region.Brazil, ["\\(Brazil\\)", "\\(BR\\)"] }
    };

    // World/International patterns (indicates multi-region)
    private static readonly string[] WorldPatterns = ["\\(World\\)", "\\(International\\)", "\\(Multi\\)", "\\[W\\]"];

    public bool CanDetect(string filePath)
    {
        return !string.IsNullOrWhiteSpace(filePath);
    }

    public Region[] Detect(string filePath)
    {
        if (!CanDetect(filePath))
        {
            return [Region.Unknown];
        }

        var filename = Path.GetFileNameWithoutExtension(filePath);
        var detectedRegions = new HashSet<Region>();

        // Check for world/international patterns first
        if (WorldPatterns.Any(pattern => Regex.IsMatch(filename, pattern, RegexOptions.IgnoreCase)))
        {
            // World version detected - could be multiple regions
            // Try to detect specific regions too
            foreach (var (region, patterns) in RegionPatterns)
            {
                if (patterns.Any(p => Regex.IsMatch(filename, p, RegexOptions.IgnoreCase)))
                {
                    detectedRegions.Add(region);
                }
            }

            if (detectedRegions.Count > 0)
            {
                return detectedRegions.OrderBy(r => r).ToArray();
            }

            // If no specific regions found with World tag, return World detected as multiple regions
            return [Region.USA, Region.Europe, Region.Japan];
        }

        // Check for specific region patterns
        foreach (var (region, patterns) in RegionPatterns)
        {
            if (patterns.Any(p => Regex.IsMatch(filename, p, RegexOptions.IgnoreCase)))
            {
                detectedRegions.Add(region);
            }
        }

        return detectedRegions.Count > 0 
            ? detectedRegions.OrderBy(r => r).ToArray() 
            : [Region.Unknown];
    }
}
