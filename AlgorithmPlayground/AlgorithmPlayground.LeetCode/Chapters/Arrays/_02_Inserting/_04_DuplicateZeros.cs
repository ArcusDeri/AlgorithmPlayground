namespace AlgorithmPlayground.LeetCode.Chapters.Arrays._02_Inserting;

public static class _04_DuplicateZeros
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/fun-with-arrays/525/inserting-items-into-an-array/3245/
    /// </summary>
    public static void DuplicateZeros(int[] arr)
    {
        var possibleDuplicates = 0;
        var length = arr.Length - 1;

        for (int i = 0; i <= length - possibleDuplicates; i++)
        {
            if (arr[i] == 0)
            {
                if (i == length - possibleDuplicates)
                {
                    arr[length] = 0;
                    length--;
                    break;
                }
                possibleDuplicates++;
            }
        }

        for (int i = length - possibleDuplicates; i >= 0; i--)
        {
            arr[i + possibleDuplicates] = arr[i];
            if (arr[i] == 0)
            {
                possibleDuplicates--;
                arr[i + possibleDuplicates] = 0;
            }
        }
    }
}