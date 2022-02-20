using AlgorithmPlayground.Core.Extensions;
using AlgorithmPlayground.Core.Generators;

namespace AlgorithmPlayground.Core.Algorithms.BubbleSort;

public class RecursiveBubbleSort
{
    public static void Run()
    {
        Console.WriteLine("---*** RECURSIVE BUBBLE SORT DEMO ***---\n");
        Console.WriteLine("Complexity: O(n^2).");
        RunDemo(new[] { 6, 5, 3, 1, 8, 7, 2, 4 });
        RunDemo(new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 });
        
        Console.WriteLine("Running for array of 10 random numbers");
        RunDemo(NumericGenerator.GenerateRandomArray(-100, 100, 10));

        Console.WriteLine("Running for array of 20 random numbers");
        RunDemo(NumericGenerator.GenerateRandomArray(-100, 100, 20));
        
        Console.WriteLine("Running for array of 30 random numbers");
        RunDemo(NumericGenerator.GenerateRandomArray(-100, 100, 30));
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
        var swapped = false;

        for (var i = 0; i < array.Length - 1; i++)
        {
            operationCount++;

            if (array[i + 1] < array[i])
            {
                (array[i], array[i + 1]) = (array[i + 1], array[i]);
                swapped = true;
            }
        }

        if (swapped)
        {
            operationCount += Sort(array);
        }

        return operationCount;
    }
}