namespace AlgorithmPlayground.Core.Algorithms.Fibonacci;

public class RecursiveFibonacciGenerator
{
    public static int Generate(int n, ref int operationCount)
    {
        // Time complexity: worse than O(n^2)...
        operationCount++;
        if (n < 2)
        {
            return n;
        }

        return Generate(n - 1, ref operationCount) + Generate(n - 2, ref operationCount);
    }
}