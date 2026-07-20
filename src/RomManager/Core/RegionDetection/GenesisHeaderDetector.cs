using System;
using System.IO;
using System.Text;

namespace RomManager.Core.RegionDetection;

public class GenesisHeaderDetector : RegionDetector
{
    private static readonly string[] GenesisExtensions = [".md", ".bin", ".gen"];

    public override bool CanDetect(string filePath)
    {
        if (!base.CanDetect(filePath))
        {
            return false;
        }

        var extension = Path.GetExtension(filePath).ToLower();
        if (!GenesisExtensions.Contains(extension))
        {
            return false;
        }

        // Additional check: try to find SEGA signature
        return HasSegaSignature(filePath);
    }

    private static bool HasSegaSignature(string filePath)
    {
        try
        {
            using (var file = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                if (file.Length < 0x110)
                {
                    return false;
                }

                file.Seek(0x100, SeekOrigin.Begin);
                var buffer = new byte[4];
                _ = file.Read(buffer, 0, 4);

                var signature = Encoding.ASCII.GetString(buffer);
                return signature.StartsWith("SEGA");
            }
        }
        catch
        {
            return false;
        }
    }

    protected override Region[] DetectSystemSpecific(string filePath)
    {
        try
        {
            using (var file = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                if (file.Length < 0x1F0 + 2)
                {
                    return [];
                }

                // Region codes are at 0x1F0 (Domestic Code) and 0x1F1 (International Code)
                file.Seek(0x1F0, SeekOrigin.Begin);
                var domesticCode = (char)file.ReadByte();
                var internationalCode = (char)file.ReadByte();

                var regions = new System.Collections.Generic.HashSet<Region>();

                // Parse domestic code
                if (RegionCodeToRegion(domesticCode) != Region.Unknown)
                {
                    regions.Add(RegionCodeToRegion(domesticCode));
                }

                // Parse international code
                if (RegionCodeToRegion(internationalCode) != Region.Unknown)
                {
                    regions.Add(RegionCodeToRegion(internationalCode));
                }

                if (regions.Count > 0)
                {
                    var result = new System.Collections.Generic.List<Region>(regions);
                    result.Sort();
                    return result.ToArray();
                }

                return [];
            }
        }
        catch
        {
            return [];
        }
    }

    private static Region RegionCodeToRegion(char code)
    {
        return code switch
        {
            'J' => Region.Japan,
            'U' => Region.USA,
            'E' => Region.Europe,
            'K' => Region.Korea,
            'A' => Region.Australia,
            'B' => Region.Brazil,
            _ => Region.Unknown
        };
    }
}
