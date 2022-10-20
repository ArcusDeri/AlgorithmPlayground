using AlgorithmPlayground.LeetCode.Chapters.Arrays._03_Deleting;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.Arrays101;

public class _07_RemoveDuplicatesFromSortedArrayTests
{
    [Theory]
    [InlineData(new[] {1, 2, 0}, new[] {1, 2, 2})]
    [InlineData(new[] {0, 0, 1, 1, 1, 2, 2, 3, 3, 4}, new[] {0, 1, 2, 3, 4, 0, 0, 0, 0, 0})]
    public void _01_RemoveDuplicatesFromSortedArray_ShouldReturnExpectedResult(int[] expected, int[] nums)
    {
        // Arrange
        // Act
        var result = _07_RemoveDuplicatesFromSortedArray.RemoveDuplicates(nums);

        // Assert
        Assert.Equal(expected.Take(result), nums.Take(result));
    }
}