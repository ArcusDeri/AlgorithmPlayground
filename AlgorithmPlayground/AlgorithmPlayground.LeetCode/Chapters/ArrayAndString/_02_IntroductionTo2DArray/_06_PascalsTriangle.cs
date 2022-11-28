namespace AlgorithmPlayground.LeetCode.Chapters.ArrayAndString._02_IntroductionTo2DArray;

public static class _06_PascalsTriangle
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/array-and-string/202/introduction-to-2d-array/1170/
    /// </summary>
    public static IList<IList<int>> Generate(int numRows)
    {
        var rows = new List<IList<int>> {new List<int> {1}};

        if (numRows == 1)
        {
            return rows;
        }

        rows.Add(new[] {1, 1});

        if (numRows == 2)
        {
            return rows;
        }

        for (var i = 2; i < numRows; i++)
        {
            var row = new List<int>();
            for (int j = 0; j < i + 1; j++)
            {
                if (j == 0 || j == i)
                {
                    row.Add(1);
                    continue;
                }

                row.Add(rows[i - 1][j - 1] + rows[i - 1][j]);
            }

            rows.Add(row);
        }

        return rows;
    }
}