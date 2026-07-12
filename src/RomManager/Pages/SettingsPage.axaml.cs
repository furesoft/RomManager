using Avalonia.Controls;
using Design = Avalonia.Controls.Design;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using RomManager.Configurations;
using RomManager.Hosting;
using RomManager.ViewModels;

namespace RomManager.Pages;

public partial class SettingsPage : UserControl
{
    public SettingsPage()
    {
        InitializeComponent();

        if (Design.IsDesignMode)
        {
            DataContext = new SettingsPageViewModel(Options.Create(new PathsConfiguration()));
            return;
        }

        DataContext = AppHost.Services.GetRequiredService<SettingsPageViewModel>();
    }
}