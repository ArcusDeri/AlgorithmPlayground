using AlgorithmPlayground.LeetCode.Chapters.Arrays._02_Inserting;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.Arrays101;

public class _05_MergeSortedArrayTests
{
    [Theory]
    [InlineData(new[] {1, 2, 2, 3, 5, 6}, new[] {1, 2, 3, 0, 0, 0}, 3, new[] {2, 5, 6}, 3)]
    [InlineData(new[] {1}, new[] {1}, 1, new int[0], 0)]
    [InlineData(new[] {1}, new[] {0}, 0, new[] {1}, 1)]
    public void _01_MergeSortedArray_ShouldReturnExpectedResult(int[] expected, int[] nums1, int m, int[] nums2, int n)
    {
        // Arrange
        // Act
        _05_MergeSortedArray.Merge(nums1, m, nums2, n);

        // Assert
        Assert.Equal(expected, nums1);
    }

}