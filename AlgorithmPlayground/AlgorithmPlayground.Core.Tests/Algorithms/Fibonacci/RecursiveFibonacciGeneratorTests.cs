using AlgorithmPlayground.Core.Algorithms.Fibonacci;
using Xunit;

namespace AlgorithmPlayground.Core.Tests.Algorithms.Fibonacci;

public class RecursiveFibonacciGeneratorTests
{
    [Fact]
    public void Generate_ShouldReturnCorrectNthNumberAndOperationCountShouldBeGreaterThanZero_WhenCalled()
    {
        // Arrange
        var operationCount = 0;
        const int n = 10;
        
        // Act
        var result = RecursiveFibonacciGenerator.Generate(n, ref operationCount);
        
        // Assert
        Assert.Equal(55, result);
        Assert.True(operationCount > 0);
    }
}