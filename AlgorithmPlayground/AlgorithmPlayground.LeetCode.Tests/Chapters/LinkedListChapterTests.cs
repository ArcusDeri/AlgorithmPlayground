using AlgorithmPlayground.LeetCode.Chapters.LinkedList;
using AlgorithmPlayground.LeetCode.Model;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters;

public class LinkedListChapterTests
{
    [Fact]
    public void _2_HasCycle_ShouldReturnTrue_WhenGivenListIsLoopedInMiddleNode()
    {
        // Arrange
        var head = new ListNode(3);
        var middleNode = new ListNode(2, new ListNode(0));
        var lastNode = new ListNode(-4, middleNode);
        middleNode.next.next = lastNode;
        head.next = middleNode;

        // Act
        var result = _2_LinkedListCycle.HasCycle(head);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void _2_HasCycle_ShouldReturnTrue_WhenTailPointsToHead()
    {
        // Arrange
        var head = new ListNode(1);
        var tail = new ListNode(2, head);
        head.next = tail;

        // Act
        var result = _2_LinkedListCycle.HasCycle(head);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void _2_HasCycle_ShouldReturnFalse_WhenThereIsOnlyOneNode()
    {
        // Arrange
        // Act
        var result = _2_LinkedListCycle.HasCycle(new ListNode(1));

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void _2_HasCycle_ShouldReturnFalse_WhenGivenListHasNoCycle()
    {
        // Arrange
        var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4))));

        // Act
        var result = _2_LinkedListCycle.HasCycle(head);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void _3_DetectCycle_ShouldReturnExpectedNode_WhenGivenListIsLoopedInMiddleNode()
    {
        // Arrange
        var head = new ListNode(3);
        var middleNode = new ListNode(2, new ListNode(0));
        var lastNode = new ListNode(-4, middleNode);
        middleNode.next.next = lastNode;
        head.next = middleNode;

        // Act
        var result = _3_LinkedListCycleII.DetectCycle(head);

        // Assert
        Assert.Same(middleNode, result);
    }

    [Fact]
    public void _3_DetectCycle_ShouldReturnExpectedNode_WhenTailPointsToHead()
    {
        // Arrange
        var head = new ListNode(1);
        var tail = new ListNode(2, head);
        head.next = tail;

        // Act
        var result = _3_LinkedListCycleII.DetectCycle(head);

        // Assert
        Assert.Same(head, result);
    }

    [Fact]
    public void _3_DetectCycle_ShouldReturnNull_WhenGivenListHasSingleNonCyclingNode()
    {
        // Arrange
        var head = new ListNode(1);

        // Act
        var result = _3_LinkedListCycleII.DetectCycle(head);

        // Assert
        Assert.Null(result);
    }

    [Fact]
    public void _3_DetectCycle_ShouldReturnNull_WhenGivenListHasNoCycle()
    {
        // Arrange
        var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4))));

        // Act
        var result = _3_LinkedListCycleII.DetectCycle(head);

        // Assert
        Assert.Null(result);
    }

    [Fact]
    public void _4_GetIntersectionNode_ShouldReturnCorrectNode_WhenGivenListHasIntersection_v1()
    {
        // Arrange
        var commonList = new ListNode(8, new ListNode(4, new ListNode(5)));
        var listA = new ListNode(4, new ListNode(1, commonList));
        var listB = new ListNode(5, new ListNode(6, new ListNode(1, commonList)));

        // Act
        var result = _4_IntersectionOfTwoLinkedList.GetIntersectionNode(listA, listB);

        // Assert
        Assert.Same(commonList, result);
    }

    [Fact]
    public void _4_GetIntersectionNode_ShouldReturnCorrectNode_WhenGivenListHasIntersection_v2()
    {
        // Arrange
        var commonList = new ListNode(2, new ListNode(4));
        var listA = new ListNode(1, new ListNode(9, new ListNode(1, commonList)));
        var listB = new ListNode(3, commonList);

        // Act
        var result = _4_IntersectionOfTwoLinkedList.GetIntersectionNode(listA, listB);

        // Assert
        Assert.Same(commonList, result);
    }

    [Fact]
    public void _4_GetIntersectionNode_ShouldReturnNull_WhenGivenListsHaveNoCommonPart()
    {
        // Arrange
        var listA = new ListNode(2, new ListNode(6, new ListNode(4)));
        var listB = new ListNode(1, new ListNode(5));

        // Act
        var result = _4_IntersectionOfTwoLinkedList.GetIntersectionNode(listA, listB);

        // Assert
        Assert.Null(result);
    }
}