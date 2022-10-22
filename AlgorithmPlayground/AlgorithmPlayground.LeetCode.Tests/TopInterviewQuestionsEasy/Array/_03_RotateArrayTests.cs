using AlgorithmPlayground.LeetCode.TopInterviewQuestionsEasy.Array;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.TopInterviewQuestionsEasy.Array;

public class _03_RotateArrayTests
{
    [Theory]
    [InlineData(new[] {5, 6, 7, 1, 2, 3, 4}, new[] {1, 2, 3, 4, 5, 6, 7}, 3)]
    [InlineData(new[] {3, 99, -1, -100}, new[] {-1, -100, 3, 99}, 2)]
    public void Rotate_ShouldReturnExpectedResult(int[] expected, int[] nums, int k)
    {
        // Arrange
        // Act
        _03_RotateArray.Rotate(nums, k);

        // Assert
        Assert.Equal(expected, nums);
    }
}