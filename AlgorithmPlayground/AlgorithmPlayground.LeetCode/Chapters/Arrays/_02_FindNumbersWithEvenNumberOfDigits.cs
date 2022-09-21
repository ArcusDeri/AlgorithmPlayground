namespace AlgorithmPlayground.LeetCode.Chapters.Arrays;

public static class _02_FindNumbersWithEvenNumberOfDigits
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/fun-with-arrays/521/introduction/3237/
    /// </summary>
    public static int FindNumbers(int[] nums)
    {
        var evenCount = 0;
        
        foreach (var num in nums)
        {
            if (num is > 9 and < 100 or > 999 and < 10000 or > 99999){
                evenCount++;
            }
        }
        return evenCount;
    }
}