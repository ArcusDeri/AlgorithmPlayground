namespace AlgorithmPlayground.LeetCode.TopInterviewQuestionsEasy.Array;

public static class _03_RotateArray
{
    /// <summary>
    /// https://leetcode.com/explore/featured/card/top-interview-questions-easy/92/array/646/
    /// </summary>
    public static void Rotate(int[] nums, int k)
    {
        
        k %= nums.Length;
        if (k == 0)
        {
            return;
        }

        Reverse(nums, 0, nums.Length);
        Reverse(nums, 0, k);
        Reverse(nums, k, nums.Length);
    }

    private static void Reverse(int[] nums, int from, int to)
    {
        to--; // Avoid IndexOutOfRangeException
        while (from < to)
        {
            (nums[to], nums[from]) = (nums[from], nums[to]);
            to--;
            from++;
        }
    }
}