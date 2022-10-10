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

    [Fact]
    public void _5_RemoveNthFromEnd_ShouldReturnExpectedResult_WhenNEqualsTwo()
    {
        // Arrange
        var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        var expectedValueSum = 11;
        var resultValueSum = 0;

        // Act
        var result = _5_RemoveNthNodeFromEndOfList.RemoveNthFromEnd(head, 2);
        while (result is { })
        {
            resultValueSum += result.val;
            result = result.next;
        }

        // Assert
        Assert.Equal(expectedValueSum, resultValueSum);
    }

    [Fact]
    public void _5_RemoveNthFromEnd_ShouldReturnNull_WhenListHasSingleNodeAndNEqualsOne()
    {
        // Arrange
        var head = new ListNode(1);

        // Act
        var result = _5_RemoveNthNodeFromEndOfList.RemoveNthFromEnd(head, 1);

        // Assert
        Assert.Null(result);
    }

    [Fact]
    public void _5_RemoveNthFromEnd_ShouldReturnExpectedResult_WhenNEqualsOneAndListHasTwoNodes()
    {
        // Arrange
        var head = new ListNode(1, new ListNode(2));
        var expectedValue = 1;

        // Act
        var result = _5_RemoveNthNodeFromEndOfList.RemoveNthFromEnd(head, 1);

        // Assert
        Assert.Null(result.next);
        Assert.Equal(expectedValue, result.val);
    }

    [Fact]
    public void _5_RemoveNthFromEnd_ShouldReturnExpectedResult_WhenNEqualsTwoAndListHasTwoNodes()
    {
        // Arrange
        var head = new ListNode(1, new ListNode(2));
        var expectedValue = 2;

        // Act
        var result = _5_RemoveNthNodeFromEndOfList.RemoveNthFromEnd(head, 2);

        // Assert
        Assert.Null(result.next);
        Assert.Equal(expectedValue, result.val);
    }

    [Fact]
    public void _6_ReverseList_ShouldReturnNull_WhenHeadIsNull()
    {
        // Arrange
        // Act
        var result = _6_ReverseLinkedList.ReverseList(null);

        // Assert
        Assert.Null(result);
    }

    [Fact]
    public void _6_ReverseList_ShouldReturnExpectedResult_WhenListHasTwoNodes()
    {
        // Arrange
        var head = new ListNode(1, new ListNode(2));
        const int expectedFirstValue = 2, expectedSecondValue = 1;

        // Act
        var result = _6_ReverseLinkedList.ReverseList(head);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(expectedFirstValue, result.val);
        Assert.NotNull(result.next);
        Assert.Equal(expectedSecondValue, result.next.val);
    }

    [Fact]
    public void _6_ReverseList_ShouldReturnExpectedResult_WhenListHasManyNodes()
    {
        // Arrange
        var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        var expectedValues = new[] {5, 4, 3, 2, 1};
        var resultValues = new int[5];
        var i = 0;

        // Act
        var result = _6_ReverseLinkedList.ReverseList(head);
        var currentNode = result;
        while (currentNode is { })
        {
            resultValues[i] = currentNode.val;
            currentNode = currentNode.next;
            i++;
        }

        // Assert
        Assert.NotNull(result);
        Assert.Equal(expectedValues, resultValues);
    }

    [Fact]
    public void _7_RemoveElementsShould_ReturnExpectedResult_WhenGivenListHasTwoElementsToRemove()
    {
        // Arrange
        const int valueToRemove = 6;
        var head = new ListNode(1, new ListNode(2, new ListNode(valueToRemove, new ListNode(3, new ListNode(4, new ListNode(5, new ListNode(valueToRemove)))))));
        var expectedValues = new[] {1, 2, 3, 4, 5};
        var resultValues = new int[5];
        var i = 0;

        // Act
        var result = _7_RemoveLInkedListElements.RemoveElements(head, valueToRemove);
        while (result is {})
        {
            resultValues[i] = result.val;
            result = result.next;
            i++;
        }

        // Assert
        Assert.Equal(expectedValues, resultValues);
    }

    [Fact]
    public void _7_RemoveElements_ShouldReturnNull_WhenGivenListIsNull()
    {
        // Arrange
        var valueToRemove = 1;
        // Act
        var result = _7_RemoveLInkedListElements.RemoveElements(null, 1);

        // Assert
        Assert.Null(result);
    }

    [Fact]
    public void _7_RemoveElements_ShouldReturnNull_WhenAllElementsShouldBeDeleted()
    {
        // Arrange
        const int valueToRemove = 7;
        var head = new ListNode(valueToRemove, new ListNode(valueToRemove, new ListNode(valueToRemove, new ListNode(valueToRemove))));

        // Act
        var result = _7_RemoveLInkedListElements.RemoveElements(head, valueToRemove);

        // Assert
        Assert.Null(result);
    }

    [Fact]
    public void _7_RemoveElements_ShouldReturnExpectedResult_WhenFirstNodeShouldBeRemovedFromListOfTwoNodes()
    {
        // Arrange
        const int valueToRemove = 1;
        var expectedValue = 2;
        var head = new ListNode(valueToRemove, new ListNode(2));

        // Act
        var result = _7_RemoveLInkedListElements.RemoveElements(head, valueToRemove);

        // Assert
        Assert.NotNull(result);
        Assert.Null(result.next);
        Assert.Equal(expectedValue, result.val);
    }

    [Fact]
    public void _8_OddEvenList_ShouldReturnExpectedResult_v1()
    {
        // Arrange
        var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        var expectedValues = new[] {1, 3, 5, 2, 4};
        var resultValues = new int[expectedValues.Length];
        var i = 0;

        // Act
        var result = _8_OddEvenLinkedList.OddEvenList(head);
        while (result != null)
        {
            resultValues[i++] = result.val;
            result = result.next;
        }

        // Assert
        Assert.Equal(expectedValues, resultValues);
    }

    [Fact]
    public void _8_OddEvenList_ShouldReturnExpectedResult_v2()
    {
        // Arrange
        var head = new ListNode(2, new ListNode(1, new ListNode(3, new ListNode(5, new ListNode(6, new ListNode(4, new ListNode(7, new ListNode(8))))))));
        var expectedValues = new[] {2, 3, 6, 7, 1, 5, 4, 8};
        var resultValues = new int[expectedValues.Length];
        var i = 0;

        // Act
        var result = _8_OddEvenLinkedList.OddEvenList(head);
        while (result != null)
        {
            resultValues[i++] = result.val;
            result = result.next;
        }

        // Assert
        Assert.Equal(expectedValues, resultValues);
    }
}