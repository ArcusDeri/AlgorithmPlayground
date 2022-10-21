using AlgorithmPlayground.LeetCode.Chapters.BeginnersGuide._01_ChallengeProblems;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.BeginnersGuide;

public class _04_1342_NumberOfStepsToReduceANumberToZeroTests
{
    [Theory]
    [InlineData(6, 14)]
    [InlineData(4, 8)]
    [InlineData(12, 123)]
    public void NumberOfSteps_ShouldReturnExpectedResult(int expected, int num)
    {
        // Arrange
        // Act
        var result = _04_1342_NumberOfStepsToReduceANumberToZero.NumberOfSteps(num);

        // Assert
        Assert.Equal(expected, result);
    }
}