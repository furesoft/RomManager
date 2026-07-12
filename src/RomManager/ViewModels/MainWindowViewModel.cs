using CommunityToolkit.Mvvm.ComponentModel;

namespace RomManager.ViewModels;

public partial class MainWindowViewModel : ObservableObject
{
    [ObservableProperty]
    public string _greeting = "Hello from, Prism.Avalonia!";
}
