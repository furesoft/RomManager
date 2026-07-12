using Avalonia.Controls;
using RomManager.ViewModels;

namespace RomManager.Pages;

public partial class SettingsPage : UserControl
{
    public SettingsPage()
    {
        InitializeComponent();

        DataContext = new SettingsPageViewModel();
    }
}