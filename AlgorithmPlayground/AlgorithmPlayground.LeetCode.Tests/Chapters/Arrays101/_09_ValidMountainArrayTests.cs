using AlgorithmPlayground.LeetCode.Chapters.Arrays._04_Searching;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.Arrays101;

public class _09_ValidMountainArrayTests
{
    [Theory]
    [InlineData(false, new[] {2, 1})]
    [InlineData(false, new[] {3, 5, 5})]
    [InlineData(true, new[] {0, 3, 2, 1})]
    [InlineData(false, new[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9})]
    public void _01_ValidMountainArraySolve_ShouldReturnExpectedResult_WhenCalled(bool expectedResult, int[] array)
    {
        // Arrange
        // Act
        var result = _09_ValidMountainArray.Solve(array);

        // Assert
        Assert.Equal(expectedResult, result);
    }
}