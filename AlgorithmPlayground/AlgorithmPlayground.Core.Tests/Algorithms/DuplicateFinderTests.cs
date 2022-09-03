using AlgorithmPlayground.Core.Algorithms;
using Xunit;

namespace AlgorithmPlayground.Core.Tests.Algorithms;

public class DuplicateFinderTests
{
    [Theory]
    [InlineData(false, new[] {1, 2, 3, 4, 5, 6})]
    [InlineData(true, new[] {1, 10, 11, 12, 13, 1})]
    [InlineData(true, new[] {0, 0})]
    public void NaiveCheckForDuplicates_ShouldReturnExpectedResult_WhenCalled(bool expectedResult, int[] array)
    {
        // Arrange
        // Act
        var result = DuplicateFinder.NaiveCheckForDuplicates(array);

        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [InlineData(false, new[] {1, 2, 3, 4, 5, 6})]
    [InlineData(true, new[] {1, 10, 10, 20, 30, 200})]
    [InlineData(true, new[] {0, 0})]
    public void BinaryCheckForDuplicates_ShouldReturnExpectedResult_WhenCalled(bool expectedResult, int[] array)
    {
        // Arrange
        // Act
        var result = DuplicateFinder.BinaryCheckForDuplicates(array);

        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [InlineData(false, new[] {1, 2, 3, 4, 5, 6})]
    [InlineData(true, new[] {1, 10, 10, 20, 30, 200})]
    [InlineData(true, new[] {0, 0})]
    public void DictionaryBasedCheckForDuplicates_ShouldReturnExpectedResult_WhenCalled(bool expectedResult, int[] array)
    {
        // Arrange
        // Act
        var result = DuplicateFinder.DictionaryBasedCheckForDuplicates(array);

        Assert.Equal(expectedResult, result);
    }
}