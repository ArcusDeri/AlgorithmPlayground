using AlgorithmPlayground.Core.Algorithms;
using Xunit;

namespace AlgorithmPlayground.Core.Tests.Algorithms;

public class ArrayAdderTests
{
    [Fact]
    public void NaiveArraySum_ShouldReturnCorrectResult_WhenCalled()
    {
        // Arrange
        var array = new[] { 8, 23, -12, 0, 14, 3, 21};

        // Act
        var sum = ArrayAdder.NaiveArraySum(array);

        // Assert
        Assert.Equal(57, sum);
    }

    [Theory]
    [InlineData(55, new [] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10})]
    [InlineData(28, new [] {1, 5, 9, 13})]
    public void ArithmeticSequenceSum_ShouldReturnCorrectResult_WhenCalled(int expectedSum, int[] sequence)
    {
        // Arrange
        // Act
        var sum = ArrayAdder.ArithmeticSequenceSum(sequence);

        // Assert
        Assert.Equal(expectedSum, sum);
    }
}