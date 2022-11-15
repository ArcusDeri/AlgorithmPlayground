namespace AlgorithmPlayground.LeetCode.Chapters.Recursion1;

public static class _10_KthSymbolInGrammar
{
    public static int KthGrammar(int n, int k)
    {
        return GetNthRow(new[] {0}, n)[k - 1];
    }

    private static int[] GetNthRow(int[] row, int n)
    {
        if (row.Length == Math.Pow(2, n - 1))
        {
            return row;
        }

        var initialRowLength = row.Length;
        var arr = row.Concat(row).ToArray();
        for (int i = initialRowLength; i < arr.Length; i++)
        {
            arr[i] = arr[i] == 0 ? 1 : 0;
        }
        return GetNthRow(arr, n);
    }
}