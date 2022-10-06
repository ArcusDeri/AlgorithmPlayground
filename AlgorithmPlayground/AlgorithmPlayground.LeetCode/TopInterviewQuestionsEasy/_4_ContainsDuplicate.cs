namespace AlgorithmPlayground.LeetCode.TopInterviewQuestionsEasy;

public static class _4_ContainsDuplicate
{
    /// <summary>
    /// https://leetcode.com/explore/featured/card/top-interview-questions-easy/92/array/578/
    /// </summary>
    public static bool ContainsDuplicate(int[] nums)
    {
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(nums[i]))
            {
                return true;
            }

            dict[nums[i]] = nums[i];
        }

        return false;
    }
}