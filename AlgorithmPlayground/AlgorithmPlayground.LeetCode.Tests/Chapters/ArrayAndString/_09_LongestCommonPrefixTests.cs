using AlgorithmPlayground.LeetCode.Chapters.ArrayAndString;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.ArrayAndString;

public class _09_LongestCommonPrefixTests
{
    [Theory]
    [InlineData(new[] {"flower", "flow", "flight"}, "fl")]
    [InlineData(new[] {"dog", "racecar", "car"}, "")]
    [InlineData(new[] {"ab", "a"}, "a")]
    public void _01_LongestCommonPrefix_ShouldReturnExpectedResult(string[] strings, string expectedResult)
    {
        // Arrange
        // Act
        var result = _09_LongestCommonPrefix.LongestCommonPrefix(strings);

        // Assert
        Assert.Equal(expectedResult, result);
    }
}