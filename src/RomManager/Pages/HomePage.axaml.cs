using Avalonia.Controls;

namespace RomManager.Pages;

public partial class HomePage : UserControl
{
    public HomePage()
    {
        InitializeComponent();

        DataContext = new ViewModels.HomePageViewModel();
    }
}