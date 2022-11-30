using AlgorithmPlayground.LeetCode.Chapters.ArrayAndString._03_IntroductionToString;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.ArrayAndString;

public class _08_ImplementStrStrTests
{
    [Theory]
    [InlineData(0, "sadbutsad", "sad")]
    [InlineData(-1, "leetcode", "leeto")]
    public void _01_StrStr_ShouldReturnExpectedResult(int expectedResult, string haystack, string needle)
    {
        // Arrange
        // Act
        var result = _08_ImplementStrStr.StrStr(haystack, needle);

        // Assert
        Assert.Equal(expectedResult, result);
    }
}