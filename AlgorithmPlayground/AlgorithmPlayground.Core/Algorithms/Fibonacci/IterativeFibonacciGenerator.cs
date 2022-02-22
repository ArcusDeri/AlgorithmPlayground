namespace AlgorithmPlayground.Core.Algorithms.Fibonacci;

public class IterativeFibonacciGenerator
{
    public static int Generate(int n, Action<int> action)
    {
        // Time complexity: O(n). Notice constant space usage - O(1) space complexity
        int prevPrevFib = 0, prevFib = 1, currentFib = 0;
        action(0);
        action(1);

        for (var i = 2; i < n; i++)
        {
            currentFib = prevPrevFib + prevFib;
            prevPrevFib = prevFib;
            prevFib = currentFib;
            action(currentFib);
        }

        return currentFib;
    }
}