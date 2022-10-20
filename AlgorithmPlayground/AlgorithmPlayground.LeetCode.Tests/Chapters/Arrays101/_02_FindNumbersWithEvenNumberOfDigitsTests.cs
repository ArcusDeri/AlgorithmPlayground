using AlgorithmPlayground.LeetCode.Chapters.Arrays._01_Introduction;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.Arrays101;

public class _02_FindNumbersWithEvenNumberOfDigitsTests
{
    [Theory]
    [InlineData(2, new[] {12, 345, 2, 6, 7896})]
    [InlineData(1, new[] {555, 901, 482, 1771})]
    public void _01_FindNumbers_ShouldReturnExpectedResult(int expected, int[] array)
    {
        // Arrange
        // Act
        var result = _02_FindNumbersWithEvenNumberOfDigits.FindNumbers(array);

        // Assert
        Assert.Equal(expected, result);
    }
}