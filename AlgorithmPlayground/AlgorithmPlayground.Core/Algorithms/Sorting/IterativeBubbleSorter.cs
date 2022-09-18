namespace AlgorithmPlayground.Core.Algorithms.Sorting;

public class IterativeBubbleSorter
{
    public static int Sort(int[] array)
    {
        // Time complexity: O(n^2), check operationCount.
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
