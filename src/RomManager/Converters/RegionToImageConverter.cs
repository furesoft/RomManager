using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using Avalonia.Data.Converters;
using Avalonia.Media;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using RomManager.Core.RegionDetection;

namespace RomManager.Converters;

public sealed class RegionToImageConverter : IValueConverter
{
    private static readonly ConcurrentDictionary<Region, IImage?> IconCache = new();

    private static readonly Dictionary<Region, string> RegionToIcon = new()
    {
        { Region.USA, "usa" },
        { Region.Australia, "au" },
        { Region.Europe, "eu" },
        { Region.Japan, "jp" },
        { Region.Korea, "kr" },
        { Region.Brazil, "br" },
        { Region.Russia, "rus" },
        { Region.Unknown, "other" }
    };

    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is not Region region) return null;

        return IconCache.GetOrAdd(region, static region =>
        {
            var iconName = RegionToIcon[region];
            var uri = new Uri($"avares://RomManager/Assets/Icons/Regions/{iconName}.png");

            if (!AssetLoader.Exists(uri)) return null;

            using var stream = AssetLoader.Open(uri);
            return new Bitmap(stream);
        });
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotSupportedException();
    }
}
