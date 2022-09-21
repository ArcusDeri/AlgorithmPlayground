namespace AlgorithmPlayground.LeetCode.Chapters.Arrays;

public static class _07_RemoveDuplicatesFromSortedArray
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/fun-with-arrays/526/deleting-items-from-an-array/3248/
    /// </summary>
    public static int RemoveDuplicates(int[] nums)
    {
        var j = 0;
        var prev = nums[0] - 1;
        var last = nums[^1];

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == last)
            {
                nums[j] = nums[i];
                j++;
                break;
            }

            if (nums[i] != prev)
            {
                nums[j] = nums[i];
                j++;
                prev = nums[i];
            }
        }

        return j;
    }
}