using System;
using System.Threading;
using System.Threading.Tasks;

namespace RomManager.Core;

public interface IStartupInitializer
{
    string Text { get; }
    Task InitializeAsync(IProgress<int> progress, CancellationToken cancellationToken);
}