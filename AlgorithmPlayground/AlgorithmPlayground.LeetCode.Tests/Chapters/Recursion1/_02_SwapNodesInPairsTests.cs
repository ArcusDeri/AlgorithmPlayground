using Xunit;
using AlgorithmPlayground.LeetCode.Model;
using AlgorithmPlayground.LeetCode.Chapters.Recursion1._01_PrincipleOfRecursion;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.Recursion1
{
    public class _02_SwapNodesInPairsTests
    {
        [Fact]
        public void _01_SwapPairs_ShouldReturnListOfExpectedShape()
        {
            // Given
            var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4))));
            var expectedValues = new[] {2, 1, 4, 3};
            var resultValues = new int[expectedValues.Length];
            var i = 0;

            // When
            var result = _02_SwapNodesInPairs.SwapPairs(head);
            while (result is {})
            {
                resultValues[i++] = result.val;
                result = result.next;
            }
        
            // Then
            Assert.Equal(expectedValues, resultValues);
        }

        [Fact]
        public void _02_SwapPairs_ShouldReturnNull_WhenHeadIsEmpty()
        {
            // Given
            ListNode? head = null;

            // When
            var result = _02_SwapNodesInPairs.SwapPairs(head);
        
            // Then
            Assert.Null(result);
        }

        [Fact]
        public void _03_SwapPairs_ShouldReturnSingleNode_WhenHeadIsSingle()
        {
            // Given
            const int expectedValue = 1;
            var head = new ListNode(expectedValue);

            // When
            var result = _02_SwapNodesInPairs.SwapPairs(head);
        
            // Then
            Assert.NotNull(result);
            Assert.Null(result.next);
            Assert.Equal(expectedValue, result.val);
        }
    }
}
