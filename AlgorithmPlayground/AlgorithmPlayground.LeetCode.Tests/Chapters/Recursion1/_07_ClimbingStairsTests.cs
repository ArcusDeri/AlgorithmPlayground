using AlgorithmPlayground.LeetCode.Chapters.Recursion1._03_Memoization;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.Recursion1;

public class _07_ClimbingStairsTests
{
    [Theory]
    [InlineData(2, 2)]
    [InlineData(3, 3)]
    [InlineData(8, 5)]
    public void _01_ClimbStairs_ShouldReturnExpectedResult(int expectedResult, int n)
    {
        // Arrange
        var solver = new _07_ClimbingStairs();

        // Act
        var result = solver.ClimbStairs(n);

        // Assert
        Assert.Equal(expectedResult, result);
    }
}