using AlgorithmPlayground.LeetCode.Chapters.ArrayAndString._02_IntroductionTo2DArray;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.ArrayAndString;

public class _05_SpiralMatrixTests
{
    [Fact]
    public void SpiralOrder_ShouldReturnExpectedResult_ForSquareMatrix()
    {
        // Arrange
        var matrix = new[] {new[] {1, 2, 3}, new[] {4, 5, 6}, new[] {7, 8, 9}};
        var expectedResult = new[] {1, 2, 3, 6, 9, 8, 7, 4, 5};

        // Act
        var result = _05_SpiralMatrix.SpiralOrder(matrix);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void SpiralOrder_ShouldReturnExpectedResult_ForSRectangleMatrix()
    {
        // Arrange
        var matrix = new[] {new[] {1, 2, 3, 4}, new[] {5, 6, 7, 8}, new[] {9, 10, 11, 12}};
        var expectedResult = new[] {1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7};

        // Act
        var result = _05_SpiralMatrix.SpiralOrder(matrix);

        // Assert
        Assert.Equal(expectedResult, result);
    }
}