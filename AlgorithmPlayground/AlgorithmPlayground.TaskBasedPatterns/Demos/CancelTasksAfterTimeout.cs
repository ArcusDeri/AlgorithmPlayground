using System.Diagnostics;

namespace AlgorithmPlayground.TaskBasedPatterns.Demos;

public static class CancelTasksAfterTimeout
{
    private static CancellationTokenSource _cts = new ();

    private static readonly HttpClient HttpClient = new()
    {
        MaxResponseContentBufferSize = 1_000_000,
    };

    private static readonly IEnumerable<string> Urls = new[]
    {
        "https://docs.microsoft.com",
        "https://docs.microsoft.com/aspnet/core",
        "https://docs.microsoft.com/azure",
        "https://docs.microsoft.com/azure/devops",
        "https://docs.microsoft.com/dotnet",
        "https://docs.microsoft.com/dynamics365",
        "https://docs.microsoft.com/education",
        "https://docs.microsoft.com/enterprise-mobility-security",
        "https://docs.microsoft.com/gaming",
        "https://docs.microsoft.com/graph",
        "https://docs.microsoft.com/microsoft-365",
        "https://docs.microsoft.com/office",
        "https://docs.microsoft.com/powershell",
        "https://docs.microsoft.com/sql",
        "https://docs.microsoft.com/surface",
        "https://docs.microsoft.com/system-center",
        "https://docs.microsoft.com/visualstudio",
        "https://docs.microsoft.com/windows",
        "https://docs.microsoft.com/xamarin"
    };

    public static async Task Run()
    {
        _cts = new CancellationTokenSource();
        LogWithTimestamp($"{nameof(CancelListOfTasksDemo)} started, thread: {Thread.CurrentThread.ManagedThreadId}");
        LogWithTimestamp("Press ENTER to trigger cancellation...\n");

        try
        {
            _cts.CancelAfter(5000);
            await SumPageSizesAsync();
        }
        catch (OperationCanceledException)
        {
            LogWithTimestamp("Tasks cancelled: timeout");
        }
        finally
        {
            _cts.Dispose();
        }

        LogWithTimestamp($"{nameof(CancelListOfTasksDemo)} ended");
    }

    private static void LogWithTimestamp(string msg)
    {
        Console.WriteLine($"{DateTime.Now:hh:mm:ss.ffff} {msg}");
    }

    private static async Task SumPageSizesAsync()
    {
        var sw = Stopwatch.StartNew();
        LogWithTimestamp($"Summing page sizes in thread {Thread.CurrentThread.ManagedThreadId}...");
        var total = 0;
        foreach (var url in Urls)
        {
            var contentLength = await ProcessUrlAsync(url);
            total += contentLength;
        }
        sw.Stop();
        LogWithTimestamp($"Summing is ready. Total bytes: {total}");
        LogWithTimestamp($"Elapsed time: {sw.Elapsed:g}");
    }

    private static async Task<int> ProcessUrlAsync(string url)
    {
        LogWithTimestamp("Waiting for web response...");
        var response = await HttpClient.GetAsync(url, _cts.Token);
        LogWithTimestamp("Got response, reading bytes");
        var byteContent = await response.Content.ReadAsByteArrayAsync(_cts.Token);
        LogWithTimestamp($"{url,-60} {byteContent.Length,10:#,#}");

        return byteContent.Length;
    }
}