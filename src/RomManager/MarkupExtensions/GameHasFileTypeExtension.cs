using System;
using System.Globalization;
using System.Linq;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Markup.Xaml;
using RomManager.Models;

namespace RomManager.MarkupExtensions;

public sealed class GameHasFileTypeExtension : MarkupExtension
{
    public GameHasFileTypeExtension()
    {
    }

    public GameHasFileTypeExtension(Type type)
    {
        Type = type;
    }

    public Type? Type { get; set; }

    public string SourcePath { get; set; } = ".";

    public override object ProvideValue(IServiceProvider serviceProvider)
    {
        return new Binding
        {
            Path = SourcePath,
            Mode = BindingMode.OneWay,
            Converter = GameFileTypeConverter.Instance,
            ConverterParameter = Type
        };
    }

    private sealed class GameFileTypeConverter : IValueConverter
    {
        public static readonly GameFileTypeConverter Instance = new();

        public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is not Game game || parameter is not Type fileType || !typeof(IHasFilename).IsAssignableFrom(fileType))
            {
                return false;
            }

            return game.Files.Any(file => fileType.IsAssignableFrom(file.GetType()));
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
