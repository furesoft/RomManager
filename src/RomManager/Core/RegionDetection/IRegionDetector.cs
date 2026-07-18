namespace RomManager.Core.RegionDetection;

public interface IRegionDetector
{
    /// <summary>
    /// Checks if this detector can handle the given file.
    /// </summary>
    bool CanDetect(string filePath);

    /// <summary>
    /// Detects regions for the given ROM file.
    /// Returns empty array if no regions could be detected.
    /// </summary>
    Region[] Detect(string filePath);
}
