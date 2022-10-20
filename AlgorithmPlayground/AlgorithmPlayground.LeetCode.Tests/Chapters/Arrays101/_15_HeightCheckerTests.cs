using AlgorithmPlayground.LeetCode.Chapters.Arrays;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.Arrays101;

public class _15_HeightCheckerTests
{
    [Theory]
    [InlineData(3, new[] {1, 1, 4, 2, 1, 3})]
    [InlineData(5, new[] {5, 1, 2, 3, 4})]
    [InlineData(0, new[] {1, 2, 3, 4, 5})]
    public void _01_HeightChecker_ShouldReturnExpectedResult(int expected, int[] heights)
    {
        // Arrange
        // Act
        var result = _15_HeightChecker.HeightChecker(heights);

        // Assert
        Assert.Equal(expected, result);
    }
}