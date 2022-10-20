using AlgorithmPlayground.LeetCode.Chapters.Arrays._05_InPlaceOperations;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.Arrays101;

public class _13_SortArrayByParityTests
{
    [Fact]
    public void _01_SortArrayByParity_ShouldReturnExpectedResult()
    {
        // Arrange
        var array = new[] {3, 1, 2, 4};
        // Act
        var result = _13_SortArrayByParity.SortArrayByParity(array);

        // Assert
        Assert.True(result.Take(2).All(a => a % 2 == 0));
        Assert.True(result.TakeLast(2).All(a => a % 2 == 1));
    }
}