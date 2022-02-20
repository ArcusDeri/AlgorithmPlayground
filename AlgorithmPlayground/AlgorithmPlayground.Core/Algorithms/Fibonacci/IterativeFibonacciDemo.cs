using AlgorithmPlayground.Core.Extensions;

namespace AlgorithmPlayground.Core.Algorithms.Fibonacci;

public static class IterativeFibonacciDemo
{
    public static void Run()
    {
        Console.WriteLine("---*** ITERATIVE FIBONACCI NUMBER DEMO ***---\n");
        Console.WriteLine("Time complexity: O(n)");

        RunDemo(5);
        RunDemo(10);
        RunDemo(15);
    }

    private static void RunDemo(int n)
    {
        Console.WriteLine($"Computing for n = {n}.");
        var sequence = new List<int>();
        var operationCount = 0;
        ComputeFibonacciNumber(n, f =>
        {
            sequence.Add(f);
            operationCount++;
        });
        Console.WriteLine($"Computation required {operationCount} operations. Result:\n{sequence.ToFriendlyArrayString()}\n");
    }

    private static void ComputeFibonacciNumber(int n, Action<int> action)
    {
        int prevPrevFib = 0, prevFib = 1;
        action(0);
        action(1);

        for (var i = 2; i <= n; i++)
        {
            var currentFib = prevPrevFib + prevFib;
            prevPrevFib = prevFib;
            prevFib = currentFib;
            action(currentFib);
        }
        
    }
}