using AlgorithmPlayground.Core.Algorithms;
using Xunit;

namespace AlgorithmPlayground.Core.Tests;

public class CanConstructRightAngledTriangleTests
{
    [Theory]
    [InlineData(false, new[] {1f})]
    [InlineData(false, new[] {1f, 2f})]
    [InlineData(false, new[] {1f, 1f, 20f})]
    [InlineData(false, new[] {1f, 1f, 20f, 10f, 15f})]
    [InlineData(true, new[] {12f, 5f, 13f})]
    public void CanConstruct_ShouldReturnExpectedResult_ForGivenSides(bool expectedResult, float[] sides)
    {
        // Arrange
        // Act
        var result = CanConstructRightAngledTriangle.CanConstruct(sides);

        // Assert
        Assert.Equal(expectedResult, result);
    }
}