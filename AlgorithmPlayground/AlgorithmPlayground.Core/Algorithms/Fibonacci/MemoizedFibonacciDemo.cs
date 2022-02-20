using AlgorithmPlayground.Core.Extensions;

namespace AlgorithmPlayground.Core.Algorithms.Fibonacci;

public static class MemoizedFibonacciDemo
{
    public static void Run()
    {
        Console.WriteLine("---*** MEMOIZED FIBONACCI NUMBER DEMO ***---\n");
        Console.WriteLine("Time complexity: O(n)");

        RunDemo(5);
        RunDemo(10);
        RunDemo(15);
    }

    private static void RunDemo(int termCount)
    {
        Console.WriteLine($"\nComputing first {termCount} Fibonacci numbers");
        var cache = new List<int> {0, 1};
        var operationCount = 0;
        for (var i = 2; i <= termCount; i++)
        {
            cache.Add(cache[i - 2] + cache[i - 1]);
            operationCount++;
        }

        Console.WriteLine($"It took {operationCount} operations to compute the sequence:\n{cache.ToFriendlyArrayString()}");
    }
}