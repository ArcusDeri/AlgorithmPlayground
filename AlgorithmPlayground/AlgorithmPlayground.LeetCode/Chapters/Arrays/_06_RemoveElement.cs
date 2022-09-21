namespace AlgorithmPlayground.LeetCode.Chapters.Arrays;

public static class _06_RemoveElement
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/fun-with-arrays/526/deleting-items-from-an-array/3247/
    /// </summary>
    public static int RemoveElement(int[] nums, int val)
    {
        int length = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == val)
            {
                continue;
            }

            nums[length] = nums[i];
            length++;
        }

        return length;
    }
}