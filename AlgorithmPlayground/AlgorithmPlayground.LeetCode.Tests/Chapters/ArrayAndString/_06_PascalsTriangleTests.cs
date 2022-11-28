using AlgorithmPlayground.LeetCode.Chapters.ArrayAndString._02_IntroductionTo2DArray;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.ArrayAndString;

public class _06_PascalsTriangleTests
{
    [Fact]
    public void _01_Generate_ShouldReturnExpectedResult_ForRowOne()
    {
        // Arrange
        var expectedResult = new[] {new[] {1}};
        const int row = 1;

        // Act
        var result = _06_PascalsTriangle.Generate(row)
            .Select(s => s.ToArray())
            .ToArray();

        // Assert
        Assert.Equal(expectedResult,result);
    }

    [Fact]
    public void _02_Generate_ShouldReturnExpectedResult_ForRowFive()
    {
        // Arrange
        var expectedResult = new[] {new[]{1}, new[]{1, 1}, new[]{1, 2, 1}, new[]{1, 3, 3, 1}, new[]{1, 4, 6, 4, 1}};
        const int row = 5;

        // Act
        var result = _06_PascalsTriangle.Generate(row)
            .Select(s => s.ToArray())
            .ToArray();

        // Assert
        Assert.Equal(expectedResult, result);
    }
}