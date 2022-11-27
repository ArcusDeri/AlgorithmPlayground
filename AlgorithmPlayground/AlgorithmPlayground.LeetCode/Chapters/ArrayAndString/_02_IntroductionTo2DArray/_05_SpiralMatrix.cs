namespace AlgorithmPlayground.LeetCode.Chapters.ArrayAndString._02_IntroductionTo2DArray;

public static class _05_SpiralMatrix
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/array-and-string/202/introduction-to-2d-array/1168/
    /// </summary>
    public static int[] SpiralOrder(int[][] matrix)
    {
        var m = matrix.Length;
        var n = matrix[0].Length;
        var result = new int[m * n];

        var top = 0;
        var right = n - 1;
        var bottom = m - 1;
        var left = 0;
        var resultCount = 0;

        while (resultCount < m * n)
        {
            // rightwards
            for (var i = left; i <= right; i++)
            {
                result[resultCount++] = matrix[top][i];
            }
            top++;
            if (top > bottom)
            {
                break;
            }

            // downwards
            for (var i = top; i <= bottom; i++)
            {
                result[resultCount++] = matrix[i][right];
            }
            right--;
            if (right < left)
            {
                break;
            }

            // leftwards
            for (var i = right; i >= left; i--)
            {
                result[resultCount++] = matrix[bottom][i];
            }
            bottom--;
            if (top > bottom)
            {
                break;
            }

            // upwards
            for (var i = bottom; i >= top; i--)
            {
                result[resultCount++] = matrix[i][left];
            }
            left++;
            if (left > right)
            {
                break;
            }
        }

        return result;
    }
}