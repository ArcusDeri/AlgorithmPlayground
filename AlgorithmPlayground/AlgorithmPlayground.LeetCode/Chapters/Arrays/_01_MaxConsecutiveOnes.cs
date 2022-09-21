namespace AlgorithmPlayground.LeetCode.Chapters.Arrays;

public static class _01_MaxConsecutiveOnes
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/fun-with-arrays/521/introduction/3238/
    /// </summary>
    public static int FindMaxConsecutiveOnes(int[] nums)
    {
        int count = 0, resultCount = 0;

        foreach (var num in nums)
        {
            if (num == 1)
            {
                count++;
            }
            else 
            {
                resultCount = count > resultCount ? count : resultCount;
                count = 0;
            }
        }
        
        return count > resultCount ? count : resultCount;
    }
}