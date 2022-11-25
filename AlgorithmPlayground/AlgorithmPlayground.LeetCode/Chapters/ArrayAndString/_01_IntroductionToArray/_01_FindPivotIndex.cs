namespace AlgorithmPlayground.LeetCode.Chapters.ArrayAndString._01_IntroductionToArray;

public static class _01_FindPivotIndex
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/array-and-string/201/introduction-to-array/1144/
    /// </summary>
    public static int PivotIndex(int[] nums)
    {
        var sum = 0;
        var leftSum = 0;
        foreach (var num in nums)
        {
            sum += num;
        }

        for (var i = 0; i < nums.Length; i++)
        {
            if (leftSum == sum - leftSum - nums[i])
            {
                return i;
            }

            leftSum += nums[i];
        }

        return -1;
    }
}