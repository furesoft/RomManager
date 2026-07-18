using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Media.Imaging;
using Microsoft.Extensions.DependencyInjection;
using PleasantUI.Controls;
using RomManager.Core;
using RomManager.Hosting;

namespace RomManager;

public class SplashScreen : IPleasantSplashScreen
{
    public IBrush? Background { get; } = new SolidColorBrush(Color.Parse("#2D2D2D"));
    public int MinimumShowTime { get; } = 4000;
    public IImage? AppIcon { get; }
    public string? AppName { get; } = "Rom Manager";

    private static readonly ProgressBar _progressBar = new() { IsIndeterminate = true };
    private static readonly TextBlock _infoText = new() { Text = "Loading...", FontSize = 24 };

    public object? SplashScreenContent { get; } = new StackPanel
    {
        Children =
        {
            _infoText,
            _progressBar
        }
    };

    public async Task RunTasks(CancellationToken cancellationToken)
    {
        var initializers = AppHost.Services.GetServices<StartupInitializer>();
        var reporter = new ProgressbarProgressReporter(_progressBar);

        foreach (var initializer in initializers)
        {
            reporter.Report(0);
            initializer.PropertyChanged += initializerOnPropertyChanged;

            await initializer.InitializeAsync(reporter, cancellationToken);

            initializer.PropertyChanged -= initializerOnPropertyChanged;
        }

        reporter.Report(100);
        _infoText.Text = "Loading ...";
    }

    private static void initializerOnPropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName == "Text")
        {
            var initializer = (StartupInitializer)sender!;
            _infoText.Text = initializer.Text;
        }
    }
}