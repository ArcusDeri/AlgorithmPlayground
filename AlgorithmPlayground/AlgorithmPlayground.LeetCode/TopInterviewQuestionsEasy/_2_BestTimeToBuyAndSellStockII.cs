namespace AlgorithmPlayground.LeetCode.TopInterviewQuestionsEasy;

public static class _2_BestTimeToBuyAndSellStockII
{
    /// <summary>
    /// https://leetcode.com/explore/featured/card/top-interview-questions-easy/92/array/564/
    /// </summary>
    public static int MaxProfit(int[] prices)
    {
        var profit = 0;

        for (int i = 1; i < prices.Length; i++)
        {
            var potentialProfit = prices[i] - prices[i - 1];
            if (potentialProfit > 0)
            {
                profit += potentialProfit;
            }
        }

        return profit;
    }
}