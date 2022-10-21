namespace AlgorithmPlayground.LeetCode.Chapters.BeginnersGuide._01_ChallengeProblems;

public static class _02_1672_RichestCustomerWealth
{
    /// <summary>
    /// https://leetcode.com/problems/richest-customer-wealth/
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