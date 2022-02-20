namespace AlgorithmPlayground.Core.Algorithms.Fibonacci;

public static class RecursiveFibonacciDemo
{
    public static void Run()
    {
        Console.WriteLine("---*** RECURSIVE FIBONACCI NUMBER DEMO ***---\n");
        Console.WriteLine("Time complexity: worse than O(n^2)...");

        RunDemo(5);
        RunDemo(10);
        RunDemo(15);
    }

    private static void RunDemo(int n)
    {
        Console.WriteLine($"Computing for n = {n}.");
        var operationCount = 0;
        var fibonacciNumber = ComputeFibonacciTerm(n, ref operationCount);
        Console.WriteLine($"Computation required {operationCount} operations. Result: {fibonacciNumber}\n");
    }

    private static int ComputeFibonacciTerm(int n, ref int operationCount)
    {
        operationCount++;
        if (n < 2)
        {
            return n;
        }

        return ComputeFibonacciTerm(n - 1, ref operationCount) + ComputeFibonacciTerm(n - 2, ref operationCount);
    }
}