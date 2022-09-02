namespace AlgorithmPlayground.Core.Algorithms;

public static class DuplicateFinder
{
    public static bool NaiveCheckForDuplicates(int[] array)
    {
        // O(n^2)...
        for (var i = 0; i < array.Length; i++)
        {
            var currentNumber = array[i];
            for (var j = 0; j < array.Length; j++)
            {
                if (i != j)
                {
                    var otherNumber = array[j];
                    if (otherNumber == currentNumber)
                    {
                        return true;
                    }
                }
            }
        }

        return false;
    }
}