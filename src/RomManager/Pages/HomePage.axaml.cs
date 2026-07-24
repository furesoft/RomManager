using Avalonia.Controls;
using Microsoft.Extensions.DependencyInjection;
using RomManager.Hosting;
using RomManager.ViewModels;

namespace RomManager.Pages;

public partial class HomePage : UserControl
{
    public HomePage()
    {
        InitializeComponent();

        if (Design.IsDesignMode) return;

        DataContext = AppHost.Services.GetRequiredService<HomePageViewModel>();
    }
}
