using AlgorithmPlayground.LeetCode.Chapters.LinkedList._03_ClassicProblems;
using AlgorithmPlayground.LeetCode.Model;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.LinkedList;

public class _06_ReverseLinkedListTests
{
    [Fact]
    public void _01_ReverseList_ShouldReturnNull_WhenHeadIsNull()
    {
        // Arrange
        // Act
        var result = _06_ReverseLinkedList.ReverseList(null);

        // Assert
        Assert.Null(result);
    }

    [Fact]
    public void _02_ReverseList_ShouldReturnExpectedResult_WhenListHasTwoNodes()
    {
        // Arrange
        var head = new ListNode(1, new ListNode(2));
        const int expectedFirstValue = 2, expectedSecondValue = 1;

        // Act
        var result = _06_ReverseLinkedList.ReverseList(head);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(expectedFirstValue, result.val);
        Assert.NotNull(result.next);
        Assert.Equal(expectedSecondValue, result.next.val);
    }

    [Fact]
    public void _03_ReverseList_ShouldReturnExpectedResult_WhenListHasManyNodes()
    {
        // Arrange
        var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        var expectedValues = new[] {5, 4, 3, 2, 1};
        var resultValues = new int[5];
        var i = 0;

        // Act
        var result = _06_ReverseLinkedList.ReverseList(head);
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
    public void _04_ReverseListRecursively_ShouldReturnNull_WhenGivenListIsNull()
    {
        // Arrange
        ListNode? head = null;

        // Act
        var result = _06_ReverseLinkedList.ReverseListRecursively(head);

        // Assert
        Assert.Null(result);
    }

    [Fact]
    public void _05_ReverseListRecursively_ShouldReturnExpectedResult_WhenListHasManyNodes()
    {
        // Arrange
        var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        var expectedValues = new[] {5, 4, 3, 2, 1};
        var resultValues = new int[5];
        var i = 0;

        // Act
        var result = _06_ReverseLinkedList.ReverseListRecursively(head);
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
}