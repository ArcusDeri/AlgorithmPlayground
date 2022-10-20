namespace AlgorithmPlayground.LeetCode.Chapters.Arrays._01_Introduction;

public static class _03_SquaresOfSortedArray
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/fun-with-arrays/521/introduction/3240/
    /// </summary>
    public static int[] SortedSquares(int[] nums)
    {
        var result = new int[nums.Length];
        int leftIndex = 0, rightIndex = nums.Length - 1;

        for (int k = result.Length - 1; k >= 0; k--)
        {
            if (Math.Abs(nums[leftIndex]) > Math.Abs(nums[rightIndex]))
            {
                result[k] = nums[leftIndex] * nums[leftIndex];
                leftIndex++;
            }
            else
            {
                result[k] = nums[rightIndex] * nums[rightIndex];
                rightIndex--;
            }
        }
        return result;
    }
}