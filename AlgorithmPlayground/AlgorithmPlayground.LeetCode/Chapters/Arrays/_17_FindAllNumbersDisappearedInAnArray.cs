namespace AlgorithmPlayground.LeetCode.Chapters.Arrays;

public static class _17_FindAllNumbersDisappearedInAnArray
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/fun-with-arrays/523/conclusion/3270/
    /// Solution with O(n) time complexity and O(1) space complexity.
    /// </summary>
    public static IList<int> FindDisappearedNumbers(int[] nums)
    {
        var result = new List<int>(nums.Length);

        for (var i = 0; i < nums.Length; i++)
        {
            var indexOfFoundElement = Math.Abs(nums[i]) - 1;
            if (nums[indexOfFoundElement] < 0)
            {
                continue;
            }
            nums[indexOfFoundElement] *= -1;
        }

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
            {
                result.Add(i + 1);
            }
        }

        return result;
    }
}
