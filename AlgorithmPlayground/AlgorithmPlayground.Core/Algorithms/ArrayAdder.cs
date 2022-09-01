namespace AlgorithmPlayground.Core.Algorithms;

public static class ArrayAdder
{
    public static int NaiveArraySum(IEnumerable<int> array)
    {
        // Time complexity: O(n)
        var sum = 0;
        foreach (var number in array)
        {
            sum += number;
        }

        return sum;
    }

    public static int ArithmeticSequenceSum(int[] array)
    {
        // Time complexity: O(1)
        if (array.Length == 0)
        {
            return 0;
        }

        if (array.Length == 1)
        {
            return array[0];
        }

        var difference = array[1] - array[0];
        var count = array.Length;
        return count / 2 * (2 * array[0] + (count - 1) * difference);
    }
}