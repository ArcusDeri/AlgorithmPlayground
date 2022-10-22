using AlgorithmPlayground.LeetCode.TopInterviewQuestionsEasy.Array;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.TopInterviewQuestionsEasy.Array;

public class _04_ContainsDuplicateTests
{
    [Theory]
    [InlineData(true, new[] {1, 2, 3, 1})]
    [InlineData(false, new[] {1, 2, 3, 4})]
    [InlineData(true, new[] {1, 1, 1, 3, 3, 4, 3, 2, 4, 2})]
    public void ContainsDuplicate_ShouldReturnExpectedResult(bool expected, int[] nums)
    {
        // Arrange
        // Act
        var result = _04_ContainsDuplicate.ContainsDuplicate(nums);

        // Assert
        Assert.Equal(expected, result);
    }
}