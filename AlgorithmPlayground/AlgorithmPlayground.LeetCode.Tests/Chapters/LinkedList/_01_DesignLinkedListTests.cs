using AlgorithmPlayground.LeetCode.Chapters.LinkedList._01_SinglyLinkedList;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.LinkedList;

public class _01_DesignLinkedListTests
{
    [Fact]
    public void _01_DesignLinkedList_ShouldHaveExpectedShape_V1()
    {
        // Arrange
        var list = new _01_DesignLinkedList();
        const int expectedHeadVal = -1;

        // Act
        list.AddAtHead(1);
        list.AddAtTail(3);
        list.AddAtIndex(1, 2);
        list.DeleteAtIndex(1);
        list.DeleteAtIndex(3);
        list.DeleteAtIndex(0);
        list.DeleteAtIndex(0);

        // Assert
        Assert.Equal(expectedHeadVal, list.Get(0));
    }

    [Fact]
    public void _02_DesignLinkedList_ShouldHaveExpectedShape_V2()
    {
        // Arrange
        var list = new _01_DesignLinkedList();
        const int expectedHeadVal = 1;
        const int expectedTailVal = 3;
        const int expectedTailIndex = 1;

        // Act
        list.AddAtHead(1);
        list.AddAtTail(3);
        list.AddAtIndex(1, 2);
        list.DeleteAtIndex(1);

        // Assert
        Assert.NotNull(list);
        Assert.Equal(expectedHeadVal, list.Get(0));
        Assert.Equal(expectedTailVal, list.Get(expectedTailIndex));
    }

    [Fact]
    public void _03_DesignLinkedList_ShouldHaveExpectedShape_V3()
    {
        // Arrange
        var list = new _01_DesignLinkedList();
        const int expectedHeadVal = 1;
        const int expectedTailVal = 3;
        const int expectedTailIndex = 1;

        // Act
        list.AddAtHead(1);
        list.AddAtTail(3);
        list.AddAtIndex(3, 2);

        // Assert
        Assert.NotNull(list);
        Assert.Equal(expectedHeadVal, list.Get(0));
        Assert.Equal(expectedTailVal, list.Get(expectedTailIndex));
    }
}