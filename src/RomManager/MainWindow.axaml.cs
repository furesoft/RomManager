using PleasantUI.Controls;
using RomManager.ViewModels;

namespace RomManager;

public partial class MainWindow : PleasantWindow
{
    public MainWindow()
    {
        SplashScreen = new SplashScreen();

        InitializeComponent();
    }

    public MainWindow(MainWindowViewModel viewModel)
        : this()
    {
        DataContext = viewModel;
    }
}
