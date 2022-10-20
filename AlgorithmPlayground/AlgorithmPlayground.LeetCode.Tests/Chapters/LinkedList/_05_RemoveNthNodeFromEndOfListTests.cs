using AlgorithmPlayground.LeetCode.Chapters.LinkedList._02_TwoPointerTechnique;
using AlgorithmPlayground.LeetCode.Model;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.LinkedList;

public class _05_RemoveNthNodeFromEndOfListTests
{
    [Fact]
    public void _01_RemoveNthFromEnd_ShouldReturnExpectedResult_WhenNEqualsTwo()
    {
        // Arrange
        var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        var expectedValueSum = 11;
        var resultValueSum = 0;

        // Act
        var result = _05_RemoveNthNodeFromEndOfList.RemoveNthFromEnd(head, 2);
        while (result is { })
        {
            resultValueSum += result.val;
            result = result.next;
        }

        // Assert
        Assert.Equal(expectedValueSum, resultValueSum);
    }

    [Fact]
    public void _02_RemoveNthFromEnd_ShouldReturnNull_WhenListHasSingleNodeAndNEqualsOne()
    {
        // Arrange
        var head = new ListNode(1);

        // Act
        var result = _05_RemoveNthNodeFromEndOfList.RemoveNthFromEnd(head, 1);

        // Assert
        Assert.Null(result);
    }

    [Fact]
    public void _03_RemoveNthFromEnd_ShouldReturnExpectedResult_WhenNEqualsOneAndListHasTwoNodes()
    {
        // Arrange
        var head = new ListNode(1, new ListNode(2));
        var expectedValue = 1;

        // Act
        var result = _05_RemoveNthNodeFromEndOfList.RemoveNthFromEnd(head, 1);

        // Assert
        Assert.Null(result.next);
        Assert.Equal(expectedValue, result.val);
    }

    [Fact]
    public void _04_RemoveNthFromEnd_ShouldReturnExpectedResult_WhenNEqualsTwoAndListHasTwoNodes()
    {
        // Arrange
        var head = new ListNode(1, new ListNode(2));
        var expectedValue = 2;

        // Act
        var result = _05_RemoveNthNodeFromEndOfList.RemoveNthFromEnd(head, 2);

        // Assert
        Assert.Null(result.next);
        Assert.Equal(expectedValue, result.val);
    }
}