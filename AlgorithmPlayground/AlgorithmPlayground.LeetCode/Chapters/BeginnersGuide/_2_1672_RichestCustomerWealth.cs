namespace AlgorithmPlayground.LeetCode.Chapters.BeginnersGuide;

public static class _2_1672_RichestCustomerWealth
{
    /// <summary>
    /// <a href="https://leetcode.com/problems/richest-customer-wealth/">Link to problem</a>
    /// </summary>
    public static int MaximumWealth(int[][] accounts)
    {
        int max = 0;
        foreach (var account in accounts)
        {
            var currentAccountSum = 0;
            foreach (var amount in account)
            {
                currentAccountSum += amount;
            }

            max = currentAccountSum > max ? currentAccountSum : max;
        }

        return max;
    }
}