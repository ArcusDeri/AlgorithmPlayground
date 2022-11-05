namespace AlgorithmPlayground.LeetCode.Chapters.Recursion1._02_RecurrenceRelation;

public static class _05_PascalsTriangleII
{
    private static readonly Dictionary<(int column, int row), int> MemoTable = new ();

    /// <summary>
    /// https://leetcode.com/explore/learn/card/recursion-i/251/scenario-i-recurrence-relation/3234/
    /// </summary>
    public static IList<int> GetRow(int rowIndex)
    {
        var result = new List<int>();
        var i = 0;

        while (i <= rowIndex)
        {
            result.Add(GetPascalTriangleNumber(i++, rowIndex));
        }

        MemoTable.Clear();
        return result;
    }

    private static int GetPascalTriangleNumber(int column, int row)
    {
        if (MemoTable.ContainsKey((column, row)))
        {
            return MemoTable[(column, row)];
        }

        if (column == 0 || row == column)
        {
            return 1;
        }

        var result = GetPascalTriangleNumber(column - 1, row - 1) + GetPascalTriangleNumber(column, row - 1);
        MemoTable[(column, row)] = result;

        return result;
    }
}