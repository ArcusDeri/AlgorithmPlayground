namespace AlgorithmPlayground.LeetCode.Chapters.Arrays._04_Searching;

public static class _08_CheckIfNAndItsDoubleExist
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/fun-with-arrays/527/searching-for-items-in-an-array/3250/
    /// </summary>
    public static bool CheckIfExist(int[] arr)
    {
        var lookup = new Dictionary<int, int>();

        for (var i = 0; i < arr.Length; i++)
        {
            if (lookup.ContainsKey(2 * arr[i]) || arr[i] % 2 == 0 && lookup.ContainsKey(arr[i] / 2))
            {
                return true;
            }
            lookup[arr[i]] = i;
        }

        return false;
    }
}