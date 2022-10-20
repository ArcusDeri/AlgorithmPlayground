using AlgorithmPlayground.LeetCode.Chapters.LinkedList._02_TwoPointerTechnique;
using AlgorithmPlayground.LeetCode.Model;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.LinkedList;

public class _02_LinkedListCycleTests
{
    [Fact]
    public void _01_HasCycle_ShouldReturnTrue_WhenGivenListIsLoopedInMiddleNode()
    {
        // Arrange
        var head = new ListNode(3);
        var middleNode = new ListNode(2, new ListNode(0));
        var lastNode = new ListNode(-4, middleNode);
        middleNode.next.next = lastNode;
        head.next = middleNode;

        // Act
        var result = _02_LinkedListCycle.HasCycle(head);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void _02_HasCycle_ShouldReturnTrue_WhenTailPointsToHead()
    {
        // Arrange
        var head = new ListNode(1);
        var tail = new ListNode(2, head);
        head.next = tail;

        // Act
        var result = _02_LinkedListCycle.HasCycle(head);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void _03_HasCycle_ShouldReturnFalse_WhenThereIsOnlyOneNode()
    {
        // Arrange
        // Act
        var result = _02_LinkedListCycle.HasCycle(new ListNode(1));

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void _04_HasCycle_ShouldReturnFalse_WhenGivenListHasNoCycle()
    {
        // Arrange
        var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4))));

        // Act
        var result = _02_LinkedListCycle.HasCycle(head);

        // Assert
        Assert.False(result);
    }
}