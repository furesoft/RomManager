using System;
using System.Globalization;
using Avalonia.Data.Converters;

namespace RomManager.Converters;

public sealed class FilterComboBoxItemToTextConverter : IValueConverter
{
    public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        return value?.ToString() ?? "All";
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotSupportedException();
    }
}
