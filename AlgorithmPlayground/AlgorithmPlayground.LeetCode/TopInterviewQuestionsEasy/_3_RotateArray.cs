namespace AlgorithmPlayground.LeetCode.TopInterviewQuestionsEasy;

public static class _3_RotateArray
{
    /// <summary>
    /// https://leetcode.com/explore/featured/card/top-interview-questions-easy/92/array/646/
    /// </summary>
    public static void Rotate(int[] nums, int k)
    {
        // TODO: there is a better way, should be revisited in future
        if (k >= nums.Length)
        {
            k %= nums.Length;
            if (k == 0)
            {
                return;
            }
        }

        var temp = new int[k];
        for (int i = nums.Length - k, j = 0; i < nums.Length; i++, j++)
        {
            temp[j] = nums[i];
        }

        for (int i = nums.Length - 1; i >= k; i--)
        {
            nums[i] = nums[i - k];
        }

        for (int i = 0; i < temp.Length; i++)
        {
            nums[i] = temp[i];
        }
    }
}