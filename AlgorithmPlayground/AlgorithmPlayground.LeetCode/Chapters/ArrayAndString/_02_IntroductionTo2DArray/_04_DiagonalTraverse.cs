namespace AlgorithmPlayground.LeetCode.Chapters.ArrayAndString._02_IntroductionTo2DArray;

public static class _04_DiagonalTraverse
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/array-and-string/202/introduction-to-2d-array/1167/
    /// </summary>
    public static int[] FindDiagonalOrder(int[][] mat)
    {
        if (mat == null || mat.Length == 0)
        {
            return new int[0];
        }

        var row = 0;
        var col = 0;
        var m = mat.Length;
        var n = mat[0].Length;
        var result = new int[m * n];

        for (var resultCount = 0; resultCount < m * n; resultCount++)
        {
            result[resultCount] = mat[row][col];
            
            // direction is up when row + col is even
            if ((row + col) % 2 == 0)
            {
                if (col == n - 1)
                {
                    row++;
                }
                else if (row == 0)
                {
                    col++;
                }
                else
                {
                    row--;
                    col++;
                }
            }
            else
            {
                
                if (row == m - 1)
                {
                    col++;
                }
                else if (col == 0)
                {
                    row++;
                }
                else
                {
                    row++;
                    col--;
                }
            }
        }

        return result;
    }
}