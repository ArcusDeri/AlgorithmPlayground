namespace AlgorithmPlayground.LeetCode.Chapters.Recursion1._04_ComplexityAnalysis;

public static class _09_PowXn
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/recursion-i/256/complexity-analysis/2380/
    /// </summary>
    public static double MyPow(double x, int n)
    {
        if (n < 0)
        {
            return 1 / x * MyPow(1 / x, -(n + 1));
        }

        if (n == 0)
        {
            return 1;
        }

        if (n == 1)
        {
            return x;
        }

        if (n % 2 == 0)
        {
            return MyPow(x * x, n / 2);
        }

        return x * MyPow(x * x, n / 2);
    }
}