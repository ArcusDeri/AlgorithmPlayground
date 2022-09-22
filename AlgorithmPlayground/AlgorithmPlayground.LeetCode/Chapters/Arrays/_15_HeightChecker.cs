namespace AlgorithmPlayground.LeetCode.Chapters.Arrays;

public static class _15_HeightChecker
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/fun-with-arrays/523/conclusion/3228/
    /// </summary>
    public static int HeightChecker(int[] heights)
    {
        var invalidHeightCount = 0;
        var expectedHeights = new int[heights.Length];
        Array.Copy(heights, expectedHeights, heights.Length);
        Array.Sort(expectedHeights);

        for (var i = 0; i < heights.Length; i++)
        {
            if (heights[i] != expectedHeights[i])
            {
                invalidHeightCount++;
            }
        }

        return invalidHeightCount;
    }
}