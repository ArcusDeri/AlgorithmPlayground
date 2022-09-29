namespace AlgorithmPlayground.LeetCode.Chapters.BeginnersGuide;

public static class _2_1672_RichestCustomerWealth
{
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