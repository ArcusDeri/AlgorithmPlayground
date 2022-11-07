namespace AlgorithmPlayground.LeetCode.Chapters.Recursion1._03_Memoization;

public class _06_FibonacciNumber
{
    private readonly Dictionary<int, int> _memoTable = new ();

    /// <summary>
    /// https://leetcode.com/explore/learn/card/recursion-i/255/recursion-memoization/1661/
    /// </summary>
    public int Fib(int n)
    {
        if (_memoTable.ContainsKey(n))
        {
            return _memoTable[n];
        }

        if (n == 0 || n == 1)
        {
            _memoTable[n] = n;
            return n;
        }

        var result = Fib(n - 2) + Fib(n - 1);
        _memoTable[n] = result;
        return result;
    }
}