using Avalonia.Controls;
using Microsoft.Extensions.DependencyInjection;
using RomManager.Hosting;
using RomManager.ViewModels;

namespace RomManager.Pages;

public partial class LibraryPage : UserControl
{
    public LibraryPage() : this(AppHost.Services.GetRequiredService<LibraryPageViewModel>())
    {

    }
    public LibraryPage(LibraryPageViewModel viewModel)
    {
        InitializeComponent();

        DataContext = viewModel;
    }
}