using Avalonia;
using Avalonia.Controls;
using Microsoft.Extensions.DependencyInjection;
using RomManager.Hosting;

namespace RomManager.Pages;

public partial class HomePage : UserControl
{
    public HomePage()
    {
        InitializeComponent();

        if (Design.IsDesignMode)
        {
            return;
        }

        DataContext = AppHost.Services.GetRequiredService<ViewModels.HomePageViewModel>();
    }
}