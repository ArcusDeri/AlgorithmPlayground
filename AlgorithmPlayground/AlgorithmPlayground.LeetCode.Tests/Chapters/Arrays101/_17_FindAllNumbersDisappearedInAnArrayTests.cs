using AlgorithmPlayground.LeetCode.Chapters.Arrays;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.Arrays101;

public class _17_FindAllNumbersDisappearedInAnArrayTests
{
    [Theory]
    [InlineData(new[] {5, 6}, new[] {4, 3, 2, 7, 8, 2, 3, 1})]
    [InlineData(new[] {2}, new[] {1, 1})]
    public void _01_FindAllNumbersDisappearedInAnArray_ShouldReturnExpectedResult(int[] expected, int[] nums)
    {
        // Arrange
        // Act
        var result = _17_FindAllNumbersDisappearedInAnArray.FindDisappearedNumbers(nums);

        // Assert
        Assert.Equal(expected, result);
    }
}