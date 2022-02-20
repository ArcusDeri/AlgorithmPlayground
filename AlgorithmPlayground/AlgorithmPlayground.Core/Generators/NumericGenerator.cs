namespace AlgorithmPlayground.Core.Generators;

public static class NumericGenerator
{
    public static int[] GenerateRandomArray(int min, int max, int length)
    {
        var random = new Random();
        var array = new int[length];
        for (var i = 0; i < length; i++)
        {
            array[i] = random.Next(min, max);
        }

        return array;
    }
}