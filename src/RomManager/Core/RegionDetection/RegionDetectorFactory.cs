using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace RomManager.Core.RegionDetection;

public class RegionDetectorFactory
{
    private static readonly List<IRegionDetector> Detectors = new()
    {
        new SnesHeaderDetector(),
        new GenesisHeaderDetector(),
        new NesHeaderDetector(),
        new GameBoyHeaderDetector()
    };

    public static Region[] DetectRegions(string filePath)
    {
        if (string.IsNullOrWhiteSpace(filePath) || !File.Exists(filePath))
        {
            return [Region.Unknown];
        }

        // Try system-specific detectors first
        foreach (var detector in Detectors)
        {
            if (detector.CanDetect(filePath))
            {
                var regions = detector.Detect(filePath);
                if (regions.Length > 0 && regions[0] != Region.Unknown)
                {
                    return regions;
                }
            }
        }

        // Fallback to filename detection
        var filenameDetector = new FilenameRegionDetector();
        return filenameDetector.Detect(filePath);
    }
}
