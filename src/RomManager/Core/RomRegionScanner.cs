using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using RomManager.Core.RegionDetection;

namespace RomManager.Core;

public class RomRegionScanner
{
    private static readonly string[] CommonRomExtensions =
    [
        ".nes", ".sfc", ".smc", ".fig", ".swc", ".md", ".bin", ".gen",
        ".gb", ".gbc", ".gba", ".z64", ".n64", ".cue", ".iso", ".cdi",
        ".wad", ".elf", ".dol", ".iso", ".gcz", ".rom", ".zip", ".7z",
        ".rar", ".tar", ".gz"
    ];

    public List<RomRegionResult> ScanDirectory(string directoryPath)
    {
        var results = new List<RomRegionResult>();

        if (!Directory.Exists(directoryPath))
        {
            Console.WriteLine($"Directory not found: {directoryPath}");
            return results;
        }

        Console.WriteLine($"Scanning directory: {directoryPath}");

        try
        {
            var files = Directory.EnumerateFiles(directoryPath, "*", SearchOption.AllDirectories)
                .Where(f => CommonRomExtensions.Contains(Path.GetExtension(f).ToLower()))
                .ToList();

            Console.WriteLine($"Found {files.Count} potential ROM files");

            foreach (var file in files)
                try
                {
                    var regions = RegionDetectorFactory.DetectRegions(file);
                    var result = new RomRegionResult
                    {
                        FilePath = file,
                        FileName = Path.GetFileName(file),
                        Regions = regions,
                        HasMultipleRegions = regions.Length > 1 && !regions.Contains(Region.Unknown),
                        FileSize = new FileInfo(file).Length
                    };

                    results.Add(result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error processing file {file}: {ex.Message}");
                }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error scanning directory: {ex.Message}");
        }

        return results;
    }

    public string GenerateReport(List<RomRegionResult> results)
    {
        var sb = new StringBuilder();
        sb.AppendLine("=== ROM Region Detection Report ===");
        sb.AppendLine($"Timestamp: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
        sb.AppendLine($"Total ROMs Analyzed: {results.Count}");
        sb.AppendLine();

        // Statistics
        var regionStats = new Dictionary<Region, int>();
        foreach (var region in Enum.GetValues(typeof(Region)).Cast<Region>()) regionStats[region] = 0;

        foreach (var result in results)
        foreach (var region in result.Regions)
            if (regionStats.ContainsKey(region))
                regionStats[region]++;

        sb.AppendLine("--- Region Statistics ---");
        foreach (var stat in regionStats.OrderByDescending(x => x.Value))
            sb.AppendLine($"{stat.Key}: {stat.Value} ROMs");

        sb.AppendLine();
        sb.AppendLine("--- Multi-Region ROMs ---");
        var multiRegionRoms = results.Where(r => r.HasMultipleRegions).ToList();
        if (multiRegionRoms.Count > 0)
            foreach (var rom in multiRegionRoms.OrderBy(r => r.FileName))
            {
                var regions = string.Join(", ", rom.Regions);
                sb.AppendLine($"  {rom.FileName}: [{regions}]");
            }
        else
            sb.AppendLine("  No multi-region ROMs detected");

        sb.AppendLine();
        sb.AppendLine("--- Unknown Region ROMs ---");
        var unknownRoms = results.Where(r => r.Regions.Contains(Region.Unknown)).ToList();
        if (unknownRoms.Count > 0)
        {
            foreach (var rom in unknownRoms.Take(20).OrderBy(r => r.FileName))
                sb.AppendLine($"  {rom.FileName} ({Path.GetExtension(rom.FilePath)})");

            if (unknownRoms.Count > 20) sb.AppendLine($"  ... and {unknownRoms.Count - 20} more");
        }
        else
        {
            sb.AppendLine("  All ROMs have detected regions");
        }

        sb.AppendLine();
        sb.AppendLine("--- Detailed Results (First 50) ---");
        foreach (var result in results.Take(50).OrderBy(r => r.FileName))
        {
            var regions = string.Join(", ", result.Regions);
            var sizeMB = result.FileSize / (1024.0 * 1024.0);
            sb.AppendLine($"  {result.FileName,-50} [{regions,-35}] {sizeMB:F2} MB");
        }

        if (results.Count > 50) sb.AppendLine($"  ... and {results.Count - 50} more");

        return sb.ToString();
    }

    public class RomRegionResult
    {
        public required string FilePath { get; set; }
        public required string FileName { get; set; }
        public required Region[] Regions { get; set; }
        public bool HasMultipleRegions { get; set; }
        public long FileSize { get; set; }
    }
}
