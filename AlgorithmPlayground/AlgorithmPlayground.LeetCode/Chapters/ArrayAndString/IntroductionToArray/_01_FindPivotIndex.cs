namespace AlgorithmPlayground.LeetCode.Chapters.ArrayAndString.IntroductionToArray;

public static class _01_FindPivotIndex
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/array-and-string/201/introduction-to-array/1144/
    /// </summary>
    public static int PivotIndex(int[] nums)
    {
        if (nums.Length == 1)
        {
            return nums[0] == 0 ? 0 : -1;
        }

        var rightSum = 0;
        for (var i = 1; i < nums.Length; i++)
        {
            rightSum += nums[i];
        }

        if (rightSum == 0)
        {
            return 0;
        }

        var leftSum = 0;
        var pivot = 1;
        while (leftSum != rightSum && pivot < nums.Length)
        {
            leftSum += nums[pivot - 1];
            rightSum -= nums[pivot++];
        }

        return leftSum == rightSum ? pivot - 1 : -1;
    }
}