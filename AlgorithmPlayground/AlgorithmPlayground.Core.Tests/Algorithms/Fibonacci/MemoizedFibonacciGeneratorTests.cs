using AlgorithmPlayground.Core.Algorithms.Fibonacci;
using Xunit;

namespace AlgorithmPlayground.Core.Tests.Algorithms.Fibonacci;

public class MemoizedFibonacciGeneratorTests
{
    [Fact]
    public static void Generate_ShouldReturnCorrectSequence_WhenCalledForFirstTenTerms()
    {
        // Arrange
        const int termCount = 10;
        
        // Act
        var (sequence, operationCount) = MemoizedFibonacciGenerator.Generate(termCount);
        
        // Assert
        Assert.Equal(termCount, sequence.Length);
        Assert.True(operationCount > 0);
        Assert.Equal(new []{0, 1, 1, 2, 3, 5, 8, 13, 21, 34}, sequence);
    }
}