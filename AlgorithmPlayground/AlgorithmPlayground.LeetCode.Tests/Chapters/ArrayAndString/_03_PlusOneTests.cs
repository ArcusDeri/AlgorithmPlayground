using AlgorithmPlayground.LeetCode.Chapters.ArrayAndString.IntroductionToArray;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.ArrayAndString;

public class _03_PlusOneTests
{
    [Theory]
    [InlineData(new[] {1, 2, 4}, new[] {1, 2, 3})]
    [InlineData(new[] {1, 0}, new[] {9})]
    [InlineData(new[] {4, 3, 2, 2}, new[] {4, 3, 2, 1})]
    public void PlusOne_ShouldReturnExpectedResult(int[] expectedResult, int[] digits)
    {
        // Arrange
        // Act
        var result = _03_PlusOne.PlusOne(digits);

        // Assert
        Assert.Equal(expectedResult, result);
    }
}