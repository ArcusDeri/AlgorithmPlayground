using AlgorithmPlayground.LeetCode.Chapters.BeginnersGuide._01_ChallengeProblems;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.BeginnersGuide;

public class _03_412_FizzBuzzTests
{
    [Theory]
    [InlineData(new[] {"1", "2", "Fizz"}, 3)]
    [InlineData(new[] {"1", "2", "Fizz", "4", "Buzz"}, 5)]
    [InlineData(
        new[] {"1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz"},
        15)]
    public void FizzBuzz_ShouldReturnExpectedResult(string[] expectedResult, int n)
    {
        // Arrange
        // Act
        var result = _03_412_FizzBuzz.FizzBuzz(n);

        // Assert
        Assert.Equal(expectedResult, result);
    }
}