using Avalonia;
using Microsoft.Extensions.DependencyInjection;
using PleasantUI.Controls;
using RomManager.Core;
using RomManager.Hosting;
using RomManager.Pages;
using RomManager.ViewModels;

namespace RomManager;

public partial class MainWindow : PleasantWindow
{
    public MainWindow()
    {
        SplashScreen = new SplashScreen();

        InitializeComponent();
        AddCollectionMenuItems();
    }

    public MainWindow(MainWindowViewModel viewModel)
        : this()
    {
        DataContext = viewModel;
    }

    private void AddCollectionMenuItems()
    {
        var collectionCatalog = AppHost.Services.GetRequiredService<CollectionCatalog>();

        foreach (var collection in collectionCatalog.Collections)
        {
            var libraryViewModel = AppHost.Services.GetRequiredService<LibraryPageViewModel>();
            libraryViewModel.SetCollectionFilter(collection.Name, collection.Games);

            var collectionItem = new NavigationViewItem
            {
                Header = collection.Name,
                Margin = new Thickness(0, 0, 0, 3)
            };
            collectionItem.Content = new LibraryPage(libraryViewModel);
            LibraryNavigationItem.Items.Add(collectionItem);
        }
    }
}
