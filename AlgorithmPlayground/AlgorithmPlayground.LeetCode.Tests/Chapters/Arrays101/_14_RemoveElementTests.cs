using AlgorithmPlayground.LeetCode.Chapters.Arrays._05_InPlaceOperations;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.Arrays101;

public class _14_RemoveElementTests
{
    [Fact]
    public void _01_RemoveElement_ShouldReturnCorrectResult()
    {
        // Arrange
        var array = new[] {0, 1, 2, 2, 3, 0, 4, 2};
        var expected = new[] {0, 1, 3, 0, 4};

        // Act
        var result = _14_RemoveElement.RemoveElement(array, 2);

        // Assert
        Assert.Equivalent(expected, array.Take(result));
    }
}