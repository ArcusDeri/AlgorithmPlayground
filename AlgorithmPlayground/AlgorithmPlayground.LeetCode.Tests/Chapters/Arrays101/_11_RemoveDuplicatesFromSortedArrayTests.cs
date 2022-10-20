using AlgorithmPlayground.LeetCode.Chapters.Arrays._05_InPlaceOperations;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.Arrays101;

public class _11_RemoveDuplicatesFromSortedArrayTests
{
    [Fact]
    public void _01_RemoveDuplicatesFromSortedArray_ShouldReturnExpectedResult()
    {
        // Arrange
        var originalArray = new[] {1, 1, 2};
        var targetArray = new[] {1, 1, 2};

        // Act
        var result = _11_RemoveDuplicatesFromSortedArray.RemoveDuplicates(targetArray);

        // Assert
        Assert.Equivalent(originalArray.Distinct(), targetArray.Take(result));
    }
}