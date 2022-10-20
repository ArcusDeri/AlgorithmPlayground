using AlgorithmPlayground.LeetCode.Chapters.Arrays._05_InPlaceOperations;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.Arrays101;

public class _12_MoveZeroesTests
{
    [Theory]
    [InlineData(new[] {1, 3, 12, 0, 0}, new[] {0, 1, 0, 3, 12})]
    [InlineData(new[] {0}, new[] {0})]
    [InlineData(new[] {1}, new[] {1})]
    public void _02_MoveZeroes_ShouldReturnExpectedResult(int[] expected, int[] array)
    {
        // Arrange
        // Act
        _12_MoveZeroes.MoveZeroes(array);

        // Assert
        Assert.Equivalent(expected, array);
    }
}