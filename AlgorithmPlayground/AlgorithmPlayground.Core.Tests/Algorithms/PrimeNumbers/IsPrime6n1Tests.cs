using AlgorithmPlayground.Core.Algorithms.PrimeNumbers;
using Xunit;

namespace AlgorithmPlayground.Core.Tests.Algorithms.PrimeNumbers;

public class IsPrime6N1Tests
{
    [Theory]
    [InlineData(true, 2)]
    [InlineData(true, 3)]
    [InlineData(true, 5)]
    [InlineData(true, 11)]
    [InlineData(true, 13)]
    [InlineData(true, 17)]
    [InlineData(true, 67)]
    [InlineData(true, 97)]
    [InlineData(false, 0)]
    [InlineData(false, 1)]
    [InlineData(false, 4)]
    [InlineData(false, 20)]
    [InlineData(false, 21)]
    public void IsPrime_ShouldReturnExpectedResult_ForGivenNumber(bool expectedResult, int n)
    {
        // Arrange
        // Act
        var result = IsPrime6N1.IsPrime(n);

        // Assert
        Assert.Equal(expectedResult, result);
    }
}