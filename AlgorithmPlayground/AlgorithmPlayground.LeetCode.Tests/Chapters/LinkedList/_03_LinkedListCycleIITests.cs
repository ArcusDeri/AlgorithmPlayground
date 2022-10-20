using AlgorithmPlayground.LeetCode.Chapters.LinkedList._02_TwoPointerTechnique;
using AlgorithmPlayground.LeetCode.Model;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.LinkedList;

public class _03_LinkedListCycleIITests
{
    [Fact]
    public void _01_DetectCycle_ShouldReturnExpectedNode_WhenGivenListIsLoopedInMiddleNode()
    {
        // Arrange
        var head = new ListNode(3);
        var middleNode = new ListNode(2, new ListNode(0));
        var lastNode = new ListNode(-4, middleNode);
        middleNode.next.next = lastNode;
        head.next = middleNode;

        // Act
        var result = _03_LinkedListCycleII.DetectCycle(head);

        // Assert
        Assert.Same(middleNode, result);
    }

    [Fact]
    public void _02_DetectCycle_ShouldReturnExpectedNode_WhenTailPointsToHead()
    {
        // Arrange
        var head = new ListNode(1);
        var tail = new ListNode(2, head);
        head.next = tail;

        // Act
        var result = _03_LinkedListCycleII.DetectCycle(head);

        // Assert
        Assert.Same(head, result);
    }

    [Fact]
    public void _03_DetectCycle_ShouldReturnNull_WhenGivenListHasSingleNonCyclingNode()
    {
        // Arrange
        var head = new ListNode(1);

        // Act
        var result = _03_LinkedListCycleII.DetectCycle(head);

        // Assert
        Assert.Null(result);
    }

    [Fact]
    public void _04_DetectCycle_ShouldReturnNull_WhenGivenListHasNoCycle()
    {
        // Arrange
        var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4))));

        // Act
        var result = _03_LinkedListCycleII.DetectCycle(head);

        // Assert
        Assert.Null(result);
    }
}