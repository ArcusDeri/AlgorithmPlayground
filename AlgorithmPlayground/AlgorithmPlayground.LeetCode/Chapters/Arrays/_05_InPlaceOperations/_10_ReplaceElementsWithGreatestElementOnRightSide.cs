namespace AlgorithmPlayground.LeetCode.Chapters.Arrays._05_InPlaceOperations;

public static class _10_ReplaceElementsWithGreatestElementOnRightSide
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/fun-with-arrays/511/in-place-operations/3259/
    /// </summary>
    public static int[] Solve(int[] arr)
    {
        var max = -1;
        for (var i = arr.Length - 1; i >= 0 ; i--)
        {
            var temp = arr[i];
            arr[i] = max;
            max = max < temp ? temp : max;
        }

        return arr;
    }
}