using AlgorithmPlayground.LeetCode.Chapters.BeginnersGuide._01_ChallengeProblems;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.BeginnersGuide;

public class _01_1480_RunningSumOf1DArrayTests
{
    [Theory]
    [InlineData(new[] {1, 3, 6, 10}, new[] {1, 2, 3, 4})]
    [InlineData(new[] {1, 2, 3, 4, 5}, new[] {1, 1, 1, 1, 1})]
    [InlineData(new[] {3, 4, 6, 16, 17}, new[] {3, 1, 2, 10, 1})]
    public void RunningSum_ShouldReturnExpectedResult(int[] expected, int[] nums)
    {
        // Arrange
        // Act
        var result = _01_1480_RunningSumOf1DArray.RunningSum(nums);

        // Assert
        Assert.Equal(expected, result);
    }
}