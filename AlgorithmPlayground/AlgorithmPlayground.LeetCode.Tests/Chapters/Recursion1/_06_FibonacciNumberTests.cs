using AlgorithmPlayground.LeetCode.Chapters.Recursion1._03_Memoization;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.Recursion1;

public class _06_FibonacciNumberTests
{
    [Theory]
    [InlineData(1, 1)]
    [InlineData(0, 0)]
    [InlineData(2, 1)]
    [InlineData(3, 2)]
    [InlineData(4, 3)]
    [InlineData(7, 13)]
    [InlineData(10, 55)]
    public void _01_Fib_ShouldReturnExpectedResult_ForNthSequenceElement(int n, int expectedResult)
    {
        // Arrange
        var solver = new _06_FibonacciNumber();

        // Act
        var result = solver.Fib(n);

        // Assert
        Assert.Equal(expectedResult, result);
    }
}