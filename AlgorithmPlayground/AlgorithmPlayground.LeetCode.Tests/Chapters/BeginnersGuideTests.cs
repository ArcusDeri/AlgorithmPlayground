using AlgorithmPlayground.LeetCode.Chapters.BeginnersGuide;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters;

public class BeginnersGuideTests
{
    [Theory]
    [InlineData(new[] {1, 3, 6, 10}, new[] {1, 2, 3, 4})]
    [InlineData(new[] {1, 2, 3, 4, 5}, new[] {1, 1, 1, 1, 1})]
    [InlineData(new[] {3, 4, 6, 16, 17}, new[] {3, 1, 2, 10, 1})]
    public void _1_1480_RunningSum_ShouldReturnExpectedResult(int[] expected, int[] nums)
    {
        // Arrange
        // Act
        var result = _1_1480_RunningSumOf1DArray.RunningSum(nums);

        // Assert
        Assert.Equal(expected, result);
    }
}