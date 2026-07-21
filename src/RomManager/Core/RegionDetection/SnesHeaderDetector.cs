using System;
using System.IO;

namespace RomManager.Core.RegionDetection;

public class SnesHeaderDetector : RegionDetector
{
    private static readonly string[] SnesExtensions = [".sfc", ".smc", ".fig", ".swc"];

    public override bool CanDetect(string filePath)
    {
        if (!base.CanDetect(filePath))
        {
            return false;
        }

        var extension = Path.GetExtension(filePath).ToLower();
        return SnesExtensions.Contains(extension);
    }

    protected override Region[] DetectSystemSpecific(string filePath)
    {
        try
        {
            using (var file = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                // SNES ROMs can have headers at different positions
                // Try to detect the header position first
                var headerOffset = DetectHeaderOffset(file);
                if (headerOffset < 0)
                {
                    return [];
                }

                // Country code is at position 0x19 (25) in the extended header
                var countryCodeOffset = headerOffset + 0x19;
                if (countryCodeOffset + 1 > file.Length)
                {
                    return [];
                }

                file.Seek(countryCodeOffset, SeekOrigin.Begin);
                var countryCode = file.ReadByte();

                return CountryCodeToRegion(countryCode);
            }
        }
        catch
        {
            return [];
        }
    }

    private static int DetectHeaderOffset(FileStream file)
    {
        // SNES headers are typically at 0x7FB0 (with header) or 0xFFB0 (with header)
        // File size modulo 0x2000 can indicate presence of header
        var fileSize = file.Length;

        // If file size is divisible by 0x2000, it likely has a header
        if ((fileSize & 0x1FFF) == 0x200)
        {
            return 0x100; // Header at 0x100
        }

        // Standard positions for SNES header
        if (fileSize >= 0x10000)
        {
            // Try 0xFFB0 first (more common)
            return 0xFFB0;
        }

        if (fileSize >= 0x8000)
        {
            return 0x7FB0;
        }

        return -1;
    }

    private static Region[] CountryCodeToRegion(int countryCode)
    {
        return countryCode switch
        {
            0x00 => [Region.Japan],
            0x01 => [Region.USA],
            0x02 => [Region.Europe],
            0x03 => [Region.USA, Region.Europe], // Scandinavia (often same as Europe)
            0x04 => [Region.USA, Region.Europe], // Netherlands
            0x05 => [Region.USA, Region.Europe], // France
            0x06 => [Region.Europe], // Holland
            0x07 => [Region.USA, Region.Europe], // Spain
            0x08 => [Region.Europe], // Germany
            0x09 => [Region.Europe], // Italy
            0x0A => [Region.Europe], // Hong Kong
            0x0B => [Region.Europe], // Asia
            0x0C => [Region.Europe], // Korea
            0x0D => [Region.Europe], // Common
            0x0E => [Region.Europe], // Australia
            0x0F => [Region.USA, Region.Europe], // Brazil
            _ => []
        };
    }
}
