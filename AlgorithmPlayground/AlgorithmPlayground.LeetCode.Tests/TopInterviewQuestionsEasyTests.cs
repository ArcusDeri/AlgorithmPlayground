using AlgorithmPlayground.LeetCode.TopInterviewQuestionsEasy;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests;

public class TopInterviewQuestionsEasyTests
{
    [Theory]
    [InlineData(7, new[] {7, 1, 5, 3, 6, 4})]
    [InlineData(4, new[] {1, 2, 3, 4, 5})]
    [InlineData(0, new[] {7, 6, 4, 3, 1})]
    public void _2_MaxProfit_ShouldReturnExpectedResult(int expected, int[] prices)
    {
        // Arrange
        // Act
        var result = _2_BestTimeToBuyAndSellStockII.MaxProfit(prices);

        // Assert
        Assert.Equal(expected, result);
    }
}