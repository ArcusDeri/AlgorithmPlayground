namespace AlgorithmPlayground.LeetCode.Chapters.Arrays._04_Searching;

public static class _09_ValidMountainArray {

    /// <summary>
    /// https://leetcode.com/explore/learn/card/fun-with-arrays/527/searching-for-items-in-an-array/3251/
    /// <para>Constraints:</para>
    /// 1 &lt;= arr.length &lt;= 104
    /// <br/>
    /// 0 &lt;= arr[i] &lt;= 104
    /// </summary>
    public static bool Solve(int[] arr)
    {
        var limit = arr.Length;
        var i = 0;

        while (i + 1 < limit && arr[i] < arr[i + 1])
        {
            i++;
        }

        if (i == 0 || i == limit - 1)
        {
            return false;
        }

        while (i + 1 < limit && arr[i] > arr[i + 1])
        {
            i++;
        }

        return i == limit - 1;
    }
}