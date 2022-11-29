using AlgorithmPlayground.LeetCode.Chapters.ArrayAndString._03_IntroductionToString;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.ArrayAndString;

public class _07_AddBinaryTests
{
  [Theory]
  [InlineData("100", "11", "1")]
  [InlineData("10101", "1010", "1011")]
  public void _01_AddBinary_ShouldReturnExpectedResult(string expectedResult, string a, string b)
  {
    // Arrange
    // Act
    var result = _07_AddBinary.AddBinary(a, b);

    // Assert
    Assert.Equal(expectedResult, result);
  }
}