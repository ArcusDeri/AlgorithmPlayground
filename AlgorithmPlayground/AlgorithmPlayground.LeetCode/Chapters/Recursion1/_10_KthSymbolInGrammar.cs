namespace AlgorithmPlayground.LeetCode.Chapters.Recursion1;

public static class _10_KthSymbolInGrammar
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/recursion-i/253/conclusion/1675/
    /// </summary>
    /// <param name="n">Row number (1-indexed)</param>
    /// <param name="k">Kth element (1-indexed)</param>
    /// <returns>Value at Kth position</returns>
    public static int KthGrammar(int n, int k)
    {
        if (n == 1 && k == 1)
        {
            return 0;
        }

        var parentSize = (int) Math.Pow(2, n - 2);
        if (k <= parentSize)
        {
            return KthGrammar(n - 1, k);
        }

        return KthGrammar(n - 1, k - parentSize) ^ 1;
    }
}