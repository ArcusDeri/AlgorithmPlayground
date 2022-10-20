using AlgorithmPlayground.LeetCode.Chapters.LinkedList._03_ClassicProblems;
using AlgorithmPlayground.LeetCode.Model;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.LinkedList;

public class _07_RemoveLinkedListElementsTests
{
    [Fact]
    public void _01_RemoveElementsShould_ReturnExpectedResult_WhenGivenListHasTwoElementsToRemove()
    {
        // Arrange
        const int valueToRemove = 6;
        var head = new ListNode(1, new ListNode(2, new ListNode(valueToRemove, new ListNode(3, new ListNode(4, new ListNode(5, new ListNode(valueToRemove)))))));
        var expectedValues = new[] {1, 2, 3, 4, 5};
        var resultValues = new int[5];
        var i = 0;

        // Act
        var result = _07_RemoveLinkedListElements.RemoveElements(head, valueToRemove);
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
    public void _02_RemoveElements_ShouldReturnNull_WhenGivenListIsNull()
    {
        // Arrange
        const int valueToRemove = 1;

        // Act
        var result = _07_RemoveLinkedListElements.RemoveElements(null, 1);

        // Assert
        Assert.Null(result);
    }

    [Fact]
    public void _03_RemoveElements_ShouldReturnNull_WhenAllElementsShouldBeDeleted()
    {
        // Arrange
        const int valueToRemove = 7;
        var head = new ListNode(valueToRemove, new ListNode(valueToRemove, new ListNode(valueToRemove, new ListNode(valueToRemove))));

        // Act
        var result = _07_RemoveLinkedListElements.RemoveElements(head, valueToRemove);

        // Assert
        Assert.Null(result);
    }

    [Fact]
    public void _04_RemoveElements_ShouldReturnExpectedResult_WhenFirstNodeShouldBeRemovedFromListOfTwoNodes()
    {
        // Arrange
        const int valueToRemove = 1;
        var expectedValue = 2;
        var head = new ListNode(valueToRemove, new ListNode(2));

        // Act
        var result = _07_RemoveLinkedListElements.RemoveElements(head, valueToRemove);

        // Assert
        Assert.NotNull(result);
        Assert.Null(result.next);
        Assert.Equal(expectedValue, result.val);
    }

}