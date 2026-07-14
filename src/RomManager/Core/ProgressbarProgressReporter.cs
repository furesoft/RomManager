using System;
using Avalonia.Controls;

namespace RomManager.Core;

public class ProgressbarProgressReporter(ProgressBar progressBar) : IProgress<int>
{
    public void Report(int value)
    {
        progressBar.IsIndeterminate = value == -1;
        progressBar.Value = value;
    }
}