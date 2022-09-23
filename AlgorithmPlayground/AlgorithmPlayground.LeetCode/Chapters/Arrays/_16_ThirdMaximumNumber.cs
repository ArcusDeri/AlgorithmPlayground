namespace AlgorithmPlayground.LeetCode.Chapters.Arrays;

public static class _16_ThirdMaximumNumber
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/fun-with-arrays/523/conclusion/3231/
    /// </summary>
    public static int ThirdMax(int[] nums)
    {
        int? max1 = null, max2 = null, max3 = null;
        foreach (var num in nums)
        {
            if (num == max1 || num == max2 || num == max3)
            {
                continue;
            }

            if (max1 == null || num > max1)
            {
                max3 = max2;
                max2 = max1;
                max1 = num;
            }
            else if (max2 == null || num > max2)
            {
                max3 = max2;
                max2 = num;
            }
            else if (max3 == null || num > max3)
            {
                max3 = num;
            }
        }

        return max3 ?? (max1 ?? 0);
    }
}