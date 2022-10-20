using AlgorithmPlayground.LeetCode.Chapters.Arrays._01_Introduction;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.Arrays101;

public class _01_MaxConsecutiveOnesTests
{
    [Theory]
    [InlineData(3, new[] {1, 1, 0, 1, 1, 1})]
    [InlineData(2, new[] {1, 0, 1, 1, 0, 1})]
    public void _01_FindMaxConsecutiveOnes_ShouldReturnExpectedResult(int expected, int[] array)
    {
        // Arrange
        // Act
        var result = _01_MaxConsecutiveOnes.FindMaxConsecutiveOnes(array);

        // Assert
        Assert.Equal(expected, result);
    }
}