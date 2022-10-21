using AlgorithmPlayground.LeetCode.Chapters.BeginnersGuide._01_ChallengeProblems;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.BeginnersGuide;

public class _06_383_RansomNoteTests
{
    [Theory]
    [InlineData(false, "a", "b")]
    [InlineData(false, "aa", "ab")]
    [InlineData(true, "aa", "aab")]
    [InlineData(true, "aab", "baa")]
    public void CanConstruct_ShouldReturnExpectedResult(bool expected, string ransomNote, string magazine)
    {
        // Arrange
        // Act
        var result = _06_383_RansomNote.CanConstruct(ransomNote, magazine);

        // Assert
        Assert.Equal(expected, result);
    }
}