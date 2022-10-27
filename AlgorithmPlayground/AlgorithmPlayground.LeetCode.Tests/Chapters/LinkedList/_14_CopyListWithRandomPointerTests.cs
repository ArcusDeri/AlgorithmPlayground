using AlgorithmPlayground.LeetCode.Chapters.LinkedList;
using AlgorithmPlayground.LeetCode.Model;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.LinkedList;

public class _14_CopyListWithRandomPointerTests
{
    [Fact]
    public void _01_CopyRandomList_ShouldReturnListOfExpectedShape()
    {
        // Arrange
        var expectedValues = new[] {7, 13, 11, 10, 1};
        var resultValues = new int[expectedValues.Length];
        var i = 0;
        var a = new ListNodeWithRandom(7);
        var b = new ListNodeWithRandom(13);
        var c = new ListNodeWithRandom(11);
        var d = new ListNodeWithRandom(10);
        var e = new ListNodeWithRandom(1);
        a.next = b;
        b.next = c;
        c.next = d;
        d.next = e;

        b.random = a;
        c.random = e;
        d.random = c;
        e.random = a;

        // Act
        var resultNode = _14_CopyListWithRandomPointer.CopyRandomList(a);
        var curr = resultNode;
        while (curr is { })
        {
            resultValues[i++] = curr.val;
            curr = curr.next;
        }

        // Assert
        Assert.NotNull(resultNode);
        Assert.Null(resultNode.random);
        Assert.Equal(expectedValues, resultValues);
        Assert.NotSame(resultNode, a);
        Assert.Same(resultNode.next.random, resultNode);
        Assert.Same(resultNode.next.next.random, resultNode.next.next.next.next);
        Assert.Same(resultNode.next.next.next.random, resultNode.next.next);
        Assert.Same(resultNode.next.next.next.next.random, resultNode);
    }

    [Fact]
    public void _02_CopyRandomList_ShouldReturnListOfExpectedShape()
    {
        // Arrange
        var expectedValues = new[] {1, 2};
        var resultValues = new int[expectedValues.Length];
        var i = 0;
        var a = new ListNodeWithRandom(1);
        var b = new ListNodeWithRandom(2);
        a.next = b;

        a.random = b;
        b.random = b;

        // Act
        var resultNode = _14_CopyListWithRandomPointer.CopyRandomList(a);
        var curr = resultNode;
        while (curr is { })
        {
            resultValues[i++] = curr.val;
            curr = curr.next;
        }

        // Assert
        Assert.NotNull(resultNode);
        Assert.Equal(expectedValues, resultValues);
        Assert.NotSame(resultNode, a);
        Assert.Same(resultNode.random, resultNode.next);
        Assert.Same(resultNode.next.random, resultNode.next);
    }

    [Fact]
    public void _03_CopyRandomList_ShouldReturnListOfExpectedShape()
    {
        // Arrange
        var expectedValues = new[] {3, 3, 3};
        var resultValues = new int[expectedValues.Length];
        var i = 0;
        var a = new ListNodeWithRandom(3);
        var b = new ListNodeWithRandom(3);
        var c = new ListNodeWithRandom(3);
        a.next = b;
        b.next = c;

        b.random = a;

        // Act
        var resultNode = _14_CopyListWithRandomPointer.CopyRandomList(a);
        var curr = resultNode;
        while (curr is { })
        {
            resultValues[i++] = curr.val;
            curr = curr.next;
        }

        // Assert
        Assert.NotNull(resultNode);
        Assert.Equal(expectedValues, resultValues);
        Assert.NotSame(resultNode, a);
        Assert.Same(resultNode.next.random, resultNode);
        Assert.Null(resultNode.random);
        Assert.Null(resultNode.next.next.random);
    }
}