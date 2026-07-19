using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Extensions.Options;
using RomManager.Configurations;

namespace RomManager.ViewModels;

public partial class HomePageViewModel : ObservableObject
{
    public HomePageViewModel(IOptions<PathsConfiguration> pathsOptions)
    {
        PathsConfiguration = pathsOptions.Value;
    }

    public PathsConfiguration PathsConfiguration { get; }
}
