using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Avalonia.Threading;

namespace RomManager.Core;

public abstract class StartupInitializer : INotifyPropertyChanged
{
    private string _text = "Loading ...";
    public string Text
    {
        get => _text;
        protected set
        {
            Dispatcher.UIThread.Invoke(() =>
            {
                SetField(ref _text, value);
            });
        }
    }

    public abstract Task InitializeAsync(IProgress<int> progress, CancellationToken cancellationToken);
    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(propertyName);

        return true;
    }
}