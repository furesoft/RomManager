using System;
using System.IO;

namespace RomManager.Core.RegionDetection;

public class GameBoyHeaderDetector : RegionDetector
{
    private static readonly string[] GameBoyExtensions = { ".gb", ".gbc" };

    // Game Boy header starts at 0x100, has "Nintendo" signature at 0x104-0x133
    private const int NINTENDO_SIGNATURE_OFFSET = 0x104;

    public override bool CanDetect(string filePath)
    {
        if (!base.CanDetect(filePath))
        {
            return false;
        }

        var extension = Path.GetExtension(filePath).ToLower();
        return GameBoyExtensions.Contains(extension);
    }

    protected override Region[] DetectSystemSpecific(string filePath)
    {
        try
        {
            using (var file = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                if (file.Length < 0x150)
                {
                    return [];
                }

                // Game Boy region is typically not reliably stored in header
                // Region code is at 0x14B (old licensee code in some variants)
                file.Seek(0x14B, SeekOrigin.Begin);
                var licenseeCode = file.ReadByte();

                // Most Game Boy games were region-free, so we use filename detection as primary
                // This is just a fallback
                return [];
            }
        }
        catch
        {
            return [];
        }
    }
}
