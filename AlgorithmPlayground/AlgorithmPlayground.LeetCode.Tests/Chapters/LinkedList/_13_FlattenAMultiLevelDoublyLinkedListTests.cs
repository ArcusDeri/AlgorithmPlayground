using AlgorithmPlayground.LeetCode.Chapters.LinkedList;
using AlgorithmPlayground.LeetCode.Model;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.LinkedList;

public class _13_FlattenAMultiLevelDoublyLinkedListTests
{
    [Fact]
    public void _01_Flatten_ShouldReturnNull_ForNullArgument()
    {
        // Arrange
        DoubleListNodeWithChild? head = null;

        // Act
        var result = _13_FlattenAMultiLevelDoublyLinkedList.Flatten(head);

        // Assert
        Assert.Null(result);
    }

    [Fact]
    public void _02_Flatten_ShouldReturnListOfExpectedShape_ForSimpleHead()
    {
        // Arrange
        var child = new DoubleListNodeWithChild(3);
        var head = new DoubleListNodeWithChild(1);
        var next = new DoubleListNodeWithChild(2, null, head);
        head.child = child;
        head.next = next;
        var expectedValues = new[] {1, 3, 2};
        var resultValues = new int[expectedValues.Length];
        var i = 0;

        // Act
        var result = _13_FlattenAMultiLevelDoublyLinkedList.Flatten(head);
        while (result is { })
        {
            resultValues[i++] = result.val;
            result = result.next;
        }

        // Assert
        Assert.Equal(expectedValues, resultValues);
    }

    [Fact]
    public void _03_Flatten_ShouldReturnListOfExpectedShape_ForComplexHead()
    {
        // Arrange
        var thirdLevel = new DoubleListNodeWithChild(11);
        thirdLevel.next = new DoubleListNodeWithChild(12, null, thirdLevel);

        var secondLevel = new DoubleListNodeWithChild(7);
        secondLevel.next = new DoubleListNodeWithChild(8, null, secondLevel, thirdLevel);
        secondLevel.next.next = new DoubleListNodeWithChild(9, null, secondLevel.next);
        secondLevel.next.next.next = new DoubleListNodeWithChild(10, null, secondLevel.next.next);

        var firstLevel = new DoubleListNodeWithChild(1);
        firstLevel.next = new DoubleListNodeWithChild(2, null, firstLevel);
        firstLevel.next.next = new DoubleListNodeWithChild(3, null, firstLevel.next, secondLevel);
        firstLevel.next.next.next = new DoubleListNodeWithChild(4, null, firstLevel.next.next);
        firstLevel.next.next.next.next = new DoubleListNodeWithChild(5, null, firstLevel.next.next.next);
        firstLevel.next.next.next.next.next = new DoubleListNodeWithChild(6, null, firstLevel.next.next.next.next);

        var expectedValues = new[] {1, 2, 3, 7, 8, 11, 12, 9, 10, 4, 5, 6};
        var resultValues = new int[expectedValues.Length];
        var i = 0;

        // Act
        var result = _13_FlattenAMultiLevelDoublyLinkedList.Flatten(firstLevel);
        while (result is { })
        {
            resultValues[i++] = result.val;
            result = result.next;
        }

        // Assert
        Assert.Equal(expectedValues, resultValues);
    }
}