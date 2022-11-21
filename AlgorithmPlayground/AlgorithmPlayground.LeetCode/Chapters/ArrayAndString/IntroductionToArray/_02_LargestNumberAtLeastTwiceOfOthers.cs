namespace AlgorithmPlayground.LeetCode.Chapters.ArrayAndString.IntroductionToArray;

public static class _02_LargestNumberAtLeastTwiceOfOthers
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/array-and-string/201/introduction-to-array/1147/
    /// </summary>
    public static int DominantIndex(int[] nums)
    {
        var secondMaxValue = 0;
        var maxValue = 0;
        var maxIndex = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] > maxValue)
            {
                secondMaxValue = maxValue;
                maxIndex = i;
                maxValue = nums[i];
            }
            else if (nums[i] > secondMaxValue)
            {
                secondMaxValue = nums[i];
            }
        }
        return maxValue >= 2 * secondMaxValue ? maxIndex : -1;
    }
}