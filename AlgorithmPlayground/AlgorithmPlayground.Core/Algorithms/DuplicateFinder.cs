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

    /// <param name="array">Sorted array</param>
    public static bool BinaryCheckForDuplicates(int[] array)
    {
        // O(n*log(n))
        int HasDuplicateOf(int val)
        {
            var min = 0;
            var max = array.Length;
            while (min <= max)
            {
                var middle = (min + max) / 2;
                if (array[middle] == val)
                {
                    return middle;
                }

                if (array[middle] < val)
                {
                    min = middle;
                }
                else
                {
                    max = middle;
                }
            }

            return -1;
        }

        for (var i = 0; i < array.Length; i++)
        {
            var indexOfLookedUpValue = HasDuplicateOf(array[i]);
            if (indexOfLookedUpValue != -1 && indexOfLookedUpValue != i)
            {
                return true;
            }
        }

        return false;
    }

    public static bool DictionaryBasedCheckForDuplicates(int[] array)
    {
        // O(n)
        var lookup = new Dictionary<int, int>();
        for (var i = 0; i < array.Length; i++)
        {
            if (lookup.ContainsKey(array[i]))
            {
                return true;
            }

            lookup[array[i]] = i;
        }

        return false;
    }
}