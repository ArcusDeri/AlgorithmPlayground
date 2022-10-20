using AlgorithmPlayground.LeetCode.Chapters.Arrays._01_Introduction;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.Arrays101;

public class _03_SquaresOfSortedArrayTests
{
    [Theory]
    [InlineData(new[] {0, 1, 9, 16, 100}, new[] {-4, -1, 0, 3, 10})]
    [InlineData(new[] {4, 9, 9, 49, 121}, new[] {-7, -3, 2, 3, 11})]
    public void _01_SortedSquares_ShouldReturnExpectedResult(int[] expected, int[] array)
    {
        // Arrange
        // Act
        var result = _03_SquaresOfSortedArray.SortedSquares(array);

        // Assert
        Assert.Equal(expected, result);
    }
}