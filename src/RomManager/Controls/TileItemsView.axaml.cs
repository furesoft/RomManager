using Avalonia;
using Avalonia.Controls;
using System.Windows.Input;

namespace RomManager.Controls;

public class TileItemsView : ItemsControl
{
    public static readonly StyledProperty<double> MinItemWidthProperty =
        AvaloniaProperty.Register<TileItemsView, double>(nameof(MinItemWidth), 120d);

    public static readonly StyledProperty<double> MinColumnSpacingProperty =
        AvaloniaProperty.Register<TileItemsView, double>(nameof(MinColumnSpacing), 12d);

    public static readonly StyledProperty<double> MinRowSpacingProperty =
        AvaloniaProperty.Register<TileItemsView, double>(nameof(MinRowSpacing), 12d);

    public static readonly StyledProperty<ICommand?> FirstPageCommandProperty =
        AvaloniaProperty.Register<TileItemsView, ICommand?>(nameof(FirstPageCommand));

    public static readonly StyledProperty<ICommand?> PreviousPageCommandProperty =
        AvaloniaProperty.Register<TileItemsView, ICommand?>(nameof(PreviousPageCommand));

    public static readonly StyledProperty<ICommand?> NextPageCommandProperty =
        AvaloniaProperty.Register<TileItemsView, ICommand?>(nameof(NextPageCommand));

    public static readonly StyledProperty<ICommand?> LastPageCommandProperty =
        AvaloniaProperty.Register<TileItemsView, ICommand?>(nameof(LastPageCommand));

    public static readonly StyledProperty<bool> HasPreviousPageProperty =
        AvaloniaProperty.Register<TileItemsView, bool>(nameof(HasPreviousPage));

    public static readonly StyledProperty<bool> HasNextPageProperty =
        AvaloniaProperty.Register<TileItemsView, bool>(nameof(HasNextPage));

    public static readonly StyledProperty<string?> PageInfoProperty =
        AvaloniaProperty.Register<TileItemsView, string?>(nameof(PageInfo));

    public static readonly StyledProperty<bool> IsPaginationVisibleProperty =
        AvaloniaProperty.Register<TileItemsView, bool>(nameof(IsPaginationVisible), true);

    public double MinItemWidth
    {
        get => GetValue(MinItemWidthProperty);
        set => SetValue(MinItemWidthProperty, value);
    }

    public double MinColumnSpacing
    {
        get => GetValue(MinColumnSpacingProperty);
        set => SetValue(MinColumnSpacingProperty, value);
    }

    public double MinRowSpacing
    {
        get => GetValue(MinRowSpacingProperty);
        set => SetValue(MinRowSpacingProperty, value);
    }

    public ICommand? FirstPageCommand
    {
        get => GetValue(FirstPageCommandProperty);
        set => SetValue(FirstPageCommandProperty, value);
    }

    public ICommand? PreviousPageCommand
    {
        get => GetValue(PreviousPageCommandProperty);
        set => SetValue(PreviousPageCommandProperty, value);
    }

    public ICommand? NextPageCommand
    {
        get => GetValue(NextPageCommandProperty);
        set => SetValue(NextPageCommandProperty, value);
    }

    public ICommand? LastPageCommand
    {
        get => GetValue(LastPageCommandProperty);
        set => SetValue(LastPageCommandProperty, value);
    }

    public bool HasPreviousPage
    {
        get => GetValue(HasPreviousPageProperty);
        set => SetValue(HasPreviousPageProperty, value);
    }

    public bool HasNextPage
    {
        get => GetValue(HasNextPageProperty);
        set => SetValue(HasNextPageProperty, value);
    }

    public string? PageInfo
    {
        get => GetValue(PageInfoProperty);
        set => SetValue(PageInfoProperty, value);
    }

    public bool IsPaginationVisible
    {
        get => GetValue(IsPaginationVisibleProperty);
        set => SetValue(IsPaginationVisibleProperty, value);
    }
}
