using AlgorithmPlayground.LeetCode.Chapters.Arrays._02_Inserting;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.Arrays101;

public class _04_DuplicateZerosTests
{
    [Theory]
    [InlineData(new[] {1, 0, 0, 2, 3, 0, 0, 4}, new[] {1, 0, 2, 3, 0, 4, 5, 0})]
    [InlineData(new[] {1, 2, 3}, new[] {1, 2, 3})]
    public void _01_DuplicateZeros_ShouldReturnExpectedResult(int[] expected, int[] array)
    {
        // Arrange
        // Act
        _04_DuplicateZeros.DuplicateZeros(array);

        // Assert
        Assert.Equal(expected, array);
    }
}