using System.Threading;
using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Media.Imaging;
using PleasantUI.Controls;

namespace RomManager;

public class SplashScreen : IPleasantSplashScreen
{
    public IBrush? Background { get; } = new SolidColorBrush(Color.Parse("#2D2D2D"));
    public int MinimumShowTime { get; } = 1000;
    public IImage? AppIcon { get; }
    public string? AppName { get; } = "Rom Manager";

    public object? SplashScreenContent { get; } = new StackPanel
    {
        Children =
        {
            new TextBlock { Text = "Loading...", FontSize = 24 },
            new ProgressBar { IsIndeterminate = true }
        }
    };
    public async Task RunTasks(CancellationToken cancellationToken)
    {
        await Task.Delay(5000, cancellationToken);
    }

}