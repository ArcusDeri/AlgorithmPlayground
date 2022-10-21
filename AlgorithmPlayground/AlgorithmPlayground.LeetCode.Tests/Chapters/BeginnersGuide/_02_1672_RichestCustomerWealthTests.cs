using AlgorithmPlayground.LeetCode.Chapters.BeginnersGuide._01_ChallengeProblems;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.BeginnersGuide;

public class _02_1672_RichestCustomerWealthTests
{
    [Theory]
    [InlineData(6, new[] {1, 2, 3}, new[] {3, 2, 1})]
    [InlineData(10, new[] {1, 5}, new[] {7, 3}, new[] {3, 5})]
    [InlineData(17, new[] {2, 8, 7}, new[] {7, 1, 3}, new[] {1, 9, 5})]
    public void MaximumWealth_ShouldReturnExpectedResult(int expectedResult, params int[][] accounts)
    {
        // Arrange
        // Act
        var result = _02_1672_RichestCustomerWealth.MaximumWealth(accounts);

        // Assert
        Assert.Equal(expectedResult, result);
    }
}