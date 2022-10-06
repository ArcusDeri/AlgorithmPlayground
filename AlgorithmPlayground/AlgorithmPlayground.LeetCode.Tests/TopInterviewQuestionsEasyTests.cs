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

    [Theory]
    [InlineData(new[] {5, 6, 7, 1, 2, 3, 4}, new[] {1, 2, 3, 4, 5, 6, 7}, 3)]
    [InlineData(new[] {3, 99, -1, -100}, new[] {-1, -100, 3, 99}, 2)]
    public void _3_Rotate_ShouldReturnExpectedResult(int[] expected, int[] nums, int k)
    {
        // Arrange
        // Act
        _3_RotateArray.Rotate(nums, k);

        // Assert
        Assert.Equal(expected, nums);
    }

    [Theory]
    [InlineData(true, new[] {1, 2, 3, 1})]
    [InlineData(false, new[] {1, 2, 3, 4})]
    [InlineData(true, new[] {1, 1, 1, 3, 3, 4, 3, 2, 4, 2})]
    public void _4_ContainsDuplicate_ShouldReturnExpectedResult(bool expected, int[] nums)
    {
        // Arrange
        // Act
        var result = _4_ContainsDuplicate.ContainsDuplicate(nums);

        // Assert
        Assert.Equal(expected, result);
    }
}