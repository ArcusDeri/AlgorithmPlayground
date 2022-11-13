using AlgorithmPlayground.LeetCode.Chapters.Recursion1._04_ComplexityAnalysis;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.Recursion1;

public class _09_PowXnTests
{
    [Theory]
    [InlineData(1024.0D, 2.0, 10)]
    [InlineData(9.26100D, 2.1, 3)]
    [InlineData(0.25000D, 2.0, -2)]
    public void _01_MyPowXn_ShouldReturnExpectedResult(double expectedResult, double x, int n)
    {
        // Arrange
        // Act
        var result = _09_PowXn.MyPow(x, n);

        // Assert
        Assert.Equal(expectedResult, Math.Round(result, 3) );
    }
}