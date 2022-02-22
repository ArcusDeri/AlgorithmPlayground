namespace AlgorithmPlayground.Core.Algorithms.Fibonacci;

public static class MemoizedFibonacciGenerator
{
    public static (int[], int) Generate(int termCount)
    {
        // Time complexity: O(n)
        var cache = new List<int> {0, 1};
        var operationCount = 0;
        for (var i = 2; i < termCount; i++)
        {
            cache.Add(cache[i - 2] + cache[i - 1]);
            operationCount++;
        }

        return (cache.ToArray(), operationCount);
    }
}