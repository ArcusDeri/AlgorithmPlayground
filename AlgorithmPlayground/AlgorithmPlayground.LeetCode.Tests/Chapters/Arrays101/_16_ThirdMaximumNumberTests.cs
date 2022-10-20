using AlgorithmPlayground.LeetCode.Chapters.Arrays;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.Arrays101;

public class _16_ThirdMaximumNumberTests
{
    [Theory]
    [InlineData(1, new[] {3, 2, 1})]
    [InlineData(2, new[] {1, 2})]
    [InlineData(1, new[] {2, 2, 3, 1})]
    [InlineData(2, new[] {1, 2, 2, 5, 3, 5})]
    public void _01_ThirdMaximumNumber_ShouldReturnExpectedResult(int expected, int[] nums)
    {
        // Arrange
        // Act
        var result = _16_ThirdMaximumNumber.ThirdMax(nums);

        // Assert
        Assert.Equal(expected, result);
    }
}