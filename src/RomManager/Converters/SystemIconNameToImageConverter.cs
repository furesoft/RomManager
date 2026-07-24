using System;
using System.Collections.Concurrent;
using System.Globalization;
using Avalonia.Data.Converters;
using Avalonia.Media;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using RomManager.Models;

namespace RomManager.Converters;

public sealed class SystemIconNameToImageConverter : IValueConverter
{
    private static readonly ConcurrentDictionary<string, IImage?> IconCache = new();

    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        var iconName = value switch
        {
            string s => s,
            SystemInfo systemInfo => systemInfo.IconName ?? $"{systemInfo.Path}.png",
            _ => null
        };

        if (string.IsNullOrWhiteSpace(iconName)) return null;

        return IconCache.GetOrAdd(iconName, static name =>
        {
            var uri = new Uri($"avares://RomManager/Assets/Icons/Systems/{name}");
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
