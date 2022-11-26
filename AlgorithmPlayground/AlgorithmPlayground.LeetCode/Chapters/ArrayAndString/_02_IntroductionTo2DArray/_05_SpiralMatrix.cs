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

        var rightLimit = n - 1;
        var leftLimit = 0;
        var upLimit = 1;
        var downLimit = m - 1;

        var row = 0;
        var col = 0;
        var dir = n > 1 ? 1 : 2;
        for (var resultCount = 0; resultCount < m * n; resultCount++)
        {
            result[resultCount] = matrix[row][col];
            if (resultCount == m * n)
            {
                return result;
            }

            switch (dir)
            {
                case 1: // rightwards
                    col++;
                    if (col == rightLimit)
                    {
                        rightLimit--;
                        dir++;
                    }
                    break;
                case 2: // downwards
                    row++;
                    if (row == downLimit)
                    {
                        downLimit--;
                        dir++;
                    }
                    break;
                case 3: // leftwards
                    col--;
                    if (col == leftLimit)
                    {
                        leftLimit++;
                        dir++;
                    }
                    break;
                case 4: // upwards
                    row--;
                    if (row == upLimit)
                    {
                        upLimit++;
                        dir = 1;
                    }
                    break;
            }
        }

        return result;
    }
}