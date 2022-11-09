namespace AlgorithmPlayground.LeetCode.Chapters.Recursion1._03_Memoization;

public class _07_ClimbingStairs
{
    private readonly Dictionary<int, int> _cache = new();

    /// <summary>
    /// https://leetcode.com/explore/learn/card/recursion-i/255/recursion-memoization/1662/
    /// </summary>
    public int ClimbStairs(int n)
    {
        if (_cache.ContainsKey(n))
        {
            return _cache[n];
        }

        if (n is 1 or 2)
        {
            _cache[n] = n;
            return n;
        }

        var result = ClimbStairs(n - 1) + ClimbStairs(n - 2);
        _cache[n] = result;
        return result;
    }
}