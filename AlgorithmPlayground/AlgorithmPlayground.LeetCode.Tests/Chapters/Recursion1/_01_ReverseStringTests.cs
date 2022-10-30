using AlgorithmPlayground.LeetCode.Chapters.Recursion1._01_PrincipleOfRecursion;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.Recursion1
{
    public class _01_ReverseStringTests
    {
        [Theory]
        [InlineData(new[] {'o', 'l', 'l', 'e', 'h' }, new[] {'h', 'e', 'l', 'l', 'o'})]
        [InlineData(new[] {'h', 'a', 'n', 'n', 'a', 'H' }, new[] {'H', 'a', 'n', 'n', 'a', 'h'})]
        public void _01_ReverseString_ShouldReturnExpectedResult(char[] expectedResult, char[] str)
        {
            // Arrange
            // Act
            _01_ReverseString.ReverseString(str);

            // Assert
            Assert.Equal(expectedResult, str);
        }
    }
}
