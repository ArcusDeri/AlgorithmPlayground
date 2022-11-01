using Xunit;
using AlgorithmPlayground.LeetCode.Model;
using AlgorithmPlayground.LeetCode.Chapters.Recursion1._02_RecurrenceRelation;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.Recursion1
{
    public class _03_ReverseLinkedListTests
    {
        [Fact]
        public void _01_ReverseList_ShouldReturnListOfExpectedShape()
        {
            // Given
            var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
            var expectedValues = new[] {5, 4, 3, 2, 1};
            var resultValues = new int[expectedValues.Length];
            var i = 0;

            // When
            var result = _03_ReverseLinkedList.ReverseList(head);
            while (result is {})
            {
                resultValues[i++] = result.val;
                result = result.next;
            }
        
            // Then
            Assert.Equal(expectedValues, resultValues);
        }

        [Fact]
        public void _02_ReverseList_ShouldReturnNull_WhenHeadIsEmpty()
        {
            // Given
            ListNode? head = null;

            // When
            var result = _03_ReverseLinkedList.ReverseList(head);
        
            // Then
            Assert.Null(result);
        }

        [Fact]
        public void _03_ReverseList_ShouldReturnListOfExpectedShape()
        {
            // Given
            const int expectedValueOfSecondNode = 1;
            const int expectedValueOfFirstNode = 2;
            var head = new ListNode(expectedValueOfSecondNode, new ListNode(expectedValueOfFirstNode));

            // When
            var result = _03_ReverseLinkedList.ReverseList(head);
        
            // Then
            Assert.NotNull(result);
            Assert.NotNull(result.next);
            Assert.Equal(expectedValueOfFirstNode, result.val);
            Assert.Equal(expectedValueOfSecondNode, result.next.val);
        }
    }
}
