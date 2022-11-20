using AlgorithmPlayground.LeetCode.Chapters.ArrayAndString.IntroductionToArray;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.ArrayAndString;

public class _01_FindPivotIndexTests
{
    [Theory]
    [InlineData(3, new[] {1, 7, 3, 6, 5, 6})]
    [InlineData(-1, new[] {1, 2, 3})]
    [InlineData(0, new[] {2, -1, 1})]
    [InlineData(6, new[] {2, -2, 3, -3, 5, -5, 9})]
    public void PivotIndex_ShouldReturnExpectedResult(int expectedResult, int[] nums)
    {
        // Arrange
        // Act
        var result = _01_FindPivotIndex.PivotIndex(nums);

        // Assert
        Assert.Equal(expectedResult, result);
    }
}