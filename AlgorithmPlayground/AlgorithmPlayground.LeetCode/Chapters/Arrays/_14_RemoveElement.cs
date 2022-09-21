namespace AlgorithmPlayground.LeetCode.Chapters.Arrays;

public static class _14_RemoveElement
{
    public static int RemoveElement(int[] nums, int val)
    {
        var result = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == val)
            {
                continue;
            }

            nums[result] = nums[i];
            result++;
        }

        return result;
    }
}