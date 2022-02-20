using AlgorithmPlayground.Core.Extensions;
using AlgorithmPlayground.Core.Generators;

namespace AlgorithmPlayground.Core.Algorithms.BubbleSort;

public static class IterativeBubbleSortDemo
{
    public static void Run()
    {
        Console.WriteLine("---*** ITERATIVE BUBBLE SORT DEMO ***---\n");
        Console.WriteLine("Time complexity: O(n^2), visible below.");
        RunDemo(new[] { 6, 5, 3, 1, 8, 7, 2, 4 });
        RunDemo(new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 });
        
        Console.WriteLine("Running for array of 10 random numbers");
        RunDemo(NumericGenerator.GenerateRandomArray(-100, 100, 10));
    }

    private static void RunDemo(int[] array)
    {
        Console.WriteLine($"Array: {array.ToFriendlyArrayString()}");
        var operationCount = Sort(array);
        Console.WriteLine($"Result: {array.ToFriendlyArrayString()}");
        Console.WriteLine($"Operation count for n = {array.Length}: {operationCount}.\n");
    }

    private static int Sort(int[] array)
    {
        var operationCount = 0;

        for (var i = 0; i < array.Length; i++)
        {
            operationCount++;

            for (var j = 0; j < array.Length - 1; j++)
            {
                operationCount++;

                if (array[j + 1] < array[j])
                {
                    (array[j], array[j + 1]) = (array[j + 1], array[j]);
                }
            }
        }

        return operationCount;
    }
}
