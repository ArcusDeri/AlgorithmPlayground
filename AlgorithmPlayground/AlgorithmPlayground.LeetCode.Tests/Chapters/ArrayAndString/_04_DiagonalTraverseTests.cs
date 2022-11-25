using AlgorithmPlayground.LeetCode.Chapters.ArrayAndString._02_IntroductionTo2DArray;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.ArrayAndString;

public class _04_DiagonalTraverseTests
{
    [Fact]
    public void _01_FindDiagonalOrder_ReturnsExpectedResult_For3x3Matrix()
    {
        // Arrange
        var matrix = new[] {new[] {1, 2, 3}, new[] {4, 5, 6}, new[] {7, 8, 9}};
        var expectedResult = new[] {1, 2, 4, 7, 5, 3, 6, 8, 9};

        // Act
        var result = _04_DiagonalTraverse.FindDiagonalOrder(matrix);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void _02_FindDiagonalOrder_ReturnsExpectedResult_For2x2Matrix()
    {
        // Arrange
        var matrix = new[] {new[] {1, 2}, new[] {3, 4}};
        var expectedResult = new[] {1, 2, 3, 4};

        // Act
        var result = _04_DiagonalTraverse.FindDiagonalOrder(matrix);

        // Assert
        Assert.Equal(expectedResult, result);
    }
}