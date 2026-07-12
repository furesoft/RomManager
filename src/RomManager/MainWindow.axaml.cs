using Avalonia.Controls;
using PleasantUI.Controls;

namespace RomManager.Views;

public partial class MainWindow : PleasantWindow
{
    public MainWindow()
    {
        SplashScreen = new SplashScreen();

        InitializeComponent();
    }
}
