using AlgorithmPlayground.LeetCode.Chapters.ArrayAndString._01_IntroductionToArray;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.ArrayAndString;

public class _02_LargestNumberAtLeastTwiceOfOthersTests
{
    [Theory]
    [InlineData(1, new[] {3, 6, 1, 0})]
    [InlineData(-1, new[] {1, 2, 3, 4})]
    [InlineData(0, new[] {1,0})]
    public void DominantIndex_ShouldReturnExpectedResult(int expectedResult, int[] nums)
    {
        // Arrange
        // Act
        var result = _02_LargestNumberAtLeastTwiceOfOthers.DominantIndex(nums);

        // Assert
        Assert.Equal(expectedResult, result);
    }
}