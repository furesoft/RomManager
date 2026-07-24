using System.Collections;
using Avalonia;
using Avalonia.Collections;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Interactivity;

namespace RomManager.Controls;

public class FilterSelector : ItemsControl
{
    public static readonly StyledProperty<IList?> SelectedItemsProperty =
        AvaloniaProperty.Register<FilterSelector, IList?>(nameof(SelectedItems));

    public FilterSelector()
    {
        AddHandler(Button.ClickEvent, OnAnyButtonClicked, RoutingStrategies.Bubble);
    }

    public IList? SelectedItems
    {
        get => GetValue(SelectedItemsProperty);
        set => SetValue(SelectedItemsProperty, value);
    }

    protected override void OnApplyTemplate(TemplateAppliedEventArgs e)
    {
        base.OnApplyTemplate(e);

        var comboBox = e.NameScope.Find<ComboBox>("PART_ComboBox");
        var addBtn = e.NameScope.Find<Button>("PART_AddButton");

        addBtn?.Click += (s, args) =>
        {
            if (comboBox?.SelectedItem is null) return;

            var selectedItems = SelectedItems;
            if (selectedItems is null)
            {
                selectedItems = new AvaloniaList<object?>();
                SelectedItems = selectedItems;
            }

            if (comboBox?.SelectedItem is not null && !selectedItems.Contains(comboBox.SelectedItem))
                selectedItems.Add(comboBox.SelectedItem);

            comboBox?.SelectedItem = null;
        };
    }

    private void OnAnyButtonClicked(object? sender, RoutedEventArgs e)
    {
        if (e.Source is not Button button || button.Name == "PART_AddButton") return;

        var selectedItems = SelectedItems;
        var item = button.Tag ?? button.DataContext;
        if (selectedItems is null || item is null || !selectedItems.Contains(item)) return;

        selectedItems.Remove(item);
        e.Handled = true;
    }
}
