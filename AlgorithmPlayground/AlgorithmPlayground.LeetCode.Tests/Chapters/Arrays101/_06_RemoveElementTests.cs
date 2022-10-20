using AlgorithmPlayground.LeetCode.Chapters.Arrays._03_Deleting;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.Arrays101;

public class _06_RemoveElementTests
{
    [Theory]
    [InlineData(new[] {2, 2, 0, 0}, new[] {3, 2, 2, 3}, 3)]
    [InlineData(new[] {0, 1, 4, 0, 3, 0, 0, 0}, new[] {0, 1, 2, 2, 3, 0, 4, 2}, 2)]
    public void _01_RemoveElement_ShouldReturnExpectedResult(int[] expected, int[] array, int val)
    {
        // Arrange
        // Act
        var result = _06_RemoveElement.RemoveElement(array, val);

        // Assert
        Assert.Equivalent(expected.Take(result), array.Take(result));
    }
}