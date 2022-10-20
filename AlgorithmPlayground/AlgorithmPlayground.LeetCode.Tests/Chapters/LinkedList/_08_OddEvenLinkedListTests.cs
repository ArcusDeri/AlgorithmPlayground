using AlgorithmPlayground.LeetCode.Chapters.LinkedList._03_ClassicProblems;
using AlgorithmPlayground.LeetCode.Model;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.LinkedList;

public class _08_OddEvenLinkedListTests
{
    [Fact]
    public void _01_OddEvenList_ShouldReturnExpectedResult_v1()
    {
        // Arrange
        var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        var expectedValues = new[] {1, 3, 5, 2, 4};
        var resultValues = new int[expectedValues.Length];
        var i = 0;

        // Act
        var result = _08_OddEvenLinkedList.OddEvenList(head);
        while (result != null)
        {
            resultValues[i++] = result.val;
            result = result.next;
        }

        // Assert
        Assert.Equal(expectedValues, resultValues);
    }

    [Fact]
    public void _02_OddEvenList_ShouldReturnExpectedResult_v2()
    {
        // Arrange
        var head = new ListNode(2, new ListNode(1, new ListNode(3, new ListNode(5, new ListNode(6, new ListNode(4, new ListNode(7, new ListNode(8))))))));
        var expectedValues = new[] {2, 3, 6, 7, 1, 5, 4, 8};
        var resultValues = new int[expectedValues.Length];
        var i = 0;

        // Act
        var result = _08_OddEvenLinkedList.OddEvenList(head);
        while (result != null)
        {
            resultValues[i++] = result.val;
            result = result.next;
        }

        // Assert
        Assert.Equal(expectedValues, resultValues);
    }
}