using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Extensions.Configuration;

namespace RomManager.ViewModels;

public partial class MainWindowViewModel : ObservableObject
{
    [ObservableProperty] private string _greeting = "Hello from Microsoft.Extensions.Hosting!";

    public MainWindowViewModel(IConfiguration configuration)
    {
        Greeting = configuration["App:Greeting"] ?? Greeting;
    }
}
