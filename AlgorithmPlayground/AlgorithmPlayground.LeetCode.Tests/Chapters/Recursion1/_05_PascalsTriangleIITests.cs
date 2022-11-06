using AlgorithmPlayground.LeetCode.Chapters.Recursion1._02_RecurrenceRelation;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.Recursion1;

public class _05_PascalsTriangleIITests
{
    [Theory]
    [InlineData(new[] {1, 3, 3, 1}, 3)]
    [InlineData(new[] {1}, 0)]
    [InlineData(new[] {1, 4, 6, 4, 1}, 4)]
    [InlineData(new[] {1, 5, 10, 10, 5, 1}, 5)]
    [InlineData(new[] {1, 1}, 1)]
    public void _01_GetRow_ShouldReturnExpectedResult_ForFourthRow(int[] expectedResult, int rowIndex)
    {
        // Arrange
        // Act
        var result = _05_PascalsTriangleII.GetRowQuickly(rowIndex);

        // Assert
        Assert.Equal(expectedResult, result);
    }
}