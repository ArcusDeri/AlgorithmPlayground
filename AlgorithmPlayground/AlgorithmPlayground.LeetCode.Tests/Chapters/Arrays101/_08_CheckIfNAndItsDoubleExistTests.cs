using AlgorithmPlayground.LeetCode.Chapters.Arrays._04_Searching;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.Arrays101;

public class _08_CheckIfNAndItsDoubleExistTests
{
    [Theory]
    [InlineData(true, new[] {10, 2, 5, 3})]
    [InlineData(false, new[] {3, 1, 7, 11})]
    public void _01_CheckIfNAndItsDoubleExist_ShouldReturnExpectedResult(bool expected, int[] nums)
    {
        // Arrange
        // Act
        var result = _08_CheckIfNAndItsDoubleExist.CheckIfExist(nums);

        // Assert
        Assert.Equal(expected, result);
    }
}