namespace AlgorithmPlayground.LeetCode.Chapters.BeginnersGuide;

public static class _3_412_FizzBuzz
{
    /// <summary>
    /// Unusual, but very fast (&lt;8ms)
    /// https://leetcode.com/problems/fizz-buzz/
    /// </summary>
    public static IList<string> FizzBuzz(int n)
    {
        var result = new string[n];

        for (int i = 1; i <= n; i++)
        {
            result[i - 1] = i.ToString();
        }

        for (int i = 2; i < n; i += 3)
        {
            result[i] = "Fizz";
        }

        for (int i = 4; i < n; i += 5)
        {
            result[i] = "Buzz";
        }

        for (int i = 14; i < n; i += 15)
        {
            result[i] = "FizzBuzz";
        }

        return result;
    }
}