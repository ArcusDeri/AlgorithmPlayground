using AlgorithmPlayground.LeetCode.Chapters.Arrays._05_InPlaceOperations;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.Arrays101;

public class _10_ReplaceElementsWithGreatestElementOnRightSideTests
{
    [Fact]
    public void _01_ReplaceElementsWithGreatestElementOnRightSide_ShouldReturnExpectedResult_WhenCalled()
    {
        // Arrange
        var expected = new[] {18, 6, 6, 6, 1, -1};
        var array = new[] {17, 18, 5, 4, 6, 1};

        // Act
        var result = _10_ReplaceElementsWithGreatestElementOnRightSide.Solve(array);

        // Assert
        Assert.Equivalent(expected, result);
    }
}