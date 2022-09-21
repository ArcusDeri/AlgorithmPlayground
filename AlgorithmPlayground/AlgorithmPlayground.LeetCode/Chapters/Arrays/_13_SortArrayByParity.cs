namespace AlgorithmPlayground.LeetCode.Chapters.Arrays;

public static class _13_SortArrayByParity
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/fun-with-arrays/511/in-place-operations/3260/
    /// </summary>
    public static int[] SortArrayByParity(int[] nums)
    {
        var left = 0;
        var right = nums.Length - 1;

        while (left < right)
        {
            if (nums[left] % 2 == 1 && nums[right] % 2 == 0)
            {
                (nums[left], nums[right]) = (nums[right], nums[left]);
            }
            
            if (nums[left] % 2 == 0)
            {
                left++;
            }

            if (nums[right] % 2 == 1)
            {
                right--;
            }
        }

        return nums;
    }
}