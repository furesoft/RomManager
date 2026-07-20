using System;
using System.IO;

namespace RomManager.Core.RegionDetection;

public class NesHeaderDetector : RegionDetector
{
    private static readonly string[] NesExtensions = [".nes"];

    private const byte InesMagic0 = 0x4E; // 'N'
    private const byte InesMagic1 = 0x45; // 'E'
    private const byte InesMagic2 = 0x53; // 'S'
    private const byte InesMagic3 = 0x1A; // EOF

    public override bool CanDetect(string filePath)
    {
        if (!base.CanDetect(filePath))
        {
            return false;
        }

        var extension = Path.GetExtension(filePath).ToLower();
        return NesExtensions.Contains(extension);
    }

    protected override Region[] DetectSystemSpecific(string filePath)
    {
        try
        {
            using (var file = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                if (file.Length < 16)
                {
                    return [];
                }

                // Check for iNES header
                var headerBuffer = new byte[4];
                _ = file.Read(headerBuffer, 0, 4);

                if (headerBuffer[0] != InesMagic0 ||
                    headerBuffer[1] != InesMagic1 ||
                    headerBuffer[2] != InesMagic2 ||
                    headerBuffer[3] != InesMagic3)
                {
                    return [];
                }

                // Read TV system byte (byte 9)
                file.Seek(9, SeekOrigin.Begin);
                var tvSystem = file.ReadByte();

                // TV system: 0 = NTSC (USA/Japan), 1 = PAL (Europe)
                return (tvSystem & 0x01) switch
                {
                    0 => [Region.USA, Region.Japan], // NTSC
                    1 => [Region.Europe], // PAL
                    _ => []
                };
            }
        }
        catch
        {
            return [];
        }
    }
}
