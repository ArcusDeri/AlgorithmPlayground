using AlgorithmPlayground.LeetCode.Chapters.Recursion1;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.Recursion1;

public class _10_KthSymbolInGrammarTests
{
    [Theory]
    [InlineData(0, 1, 1)]
    [InlineData(0, 2, 1)]
    [InlineData(1, 2, 2)]
    [InlineData(1, 3, 3)]
    public void _01_KthGrammar_ShouldReturnExpectedResult(int expectedResult, int n, int k)
    {
        // Arrange
        // Act
        var result = _10_KthSymbolInGrammar.KthGrammar(n, k);

        // Assert
        Assert.Equal(expectedResult, result);
    }
}