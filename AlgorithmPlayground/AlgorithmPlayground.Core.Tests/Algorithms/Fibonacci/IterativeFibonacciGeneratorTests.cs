using System.Collections.Generic;
using AlgorithmPlayground.Core.Algorithms.Fibonacci;
using Xunit;

namespace AlgorithmPlayground.Core.Tests.Algorithms.Fibonacci;

public class IterativeFibonacciGeneratorTests
{
    [Fact]
    public void Generate_ShouldReturnNthNumberAndPopulateGivenCollection_WhenCalled()
    {
        // Arrange
        const int n = 11;
        var sequence = new List<int>();
        
        // Act
        var result = IterativeFibonacciGenerator.Generate(n, f => sequence.Add(f));
        
        // Assert
        Assert.Equal(55, result);
        Assert.Equal(new []{0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55}, sequence);
    }
}