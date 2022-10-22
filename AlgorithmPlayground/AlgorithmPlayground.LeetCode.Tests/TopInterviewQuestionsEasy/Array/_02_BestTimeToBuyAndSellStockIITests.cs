using AlgorithmPlayground.LeetCode.TopInterviewQuestionsEasy.Array;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.TopInterviewQuestionsEasy.Array;

public class _02_BestTimeToBuyAndSellStockIITests
{
    [Theory]
    [InlineData(7, new[] {7, 1, 5, 3, 6, 4})]
    [InlineData(4, new[] {1, 2, 3, 4, 5})]
    [InlineData(0, new[] {7, 6, 4, 3, 1})]
    public void MaxProfit_ShouldReturnExpectedResult(int expected, int[] prices)
    {
        // Arrange
        // Act
        var result = _02_BestTimeToBuyAndSellStockII.MaxProfit(prices);

        // Assert
        Assert.Equal(expected, result);
    }
}