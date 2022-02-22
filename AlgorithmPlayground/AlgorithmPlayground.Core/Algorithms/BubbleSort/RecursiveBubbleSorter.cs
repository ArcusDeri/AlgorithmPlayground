namespace AlgorithmPlayground.Core.Algorithms.BubbleSort;

public static class RecursiveBubbleSorter
{
    public static int Sort(int[] array)
    {
        // Time complexity: O(n^2), check operationCount.
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