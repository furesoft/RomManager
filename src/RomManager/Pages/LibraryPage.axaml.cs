using Avalonia.Controls;

namespace RomManager.Pages;

public partial class LibraryPage : UserControl
{
    public LibraryPage()
    {
        InitializeComponent();

        DataContext = new ViewModels.LibraryPageViewModel();
    }
}