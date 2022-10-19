﻿using AlgorithmPlayground.LeetCode.Chapters.LinkedList._04_DoublyLinkedList;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.LinkedList;

public class _10_DesignDoublyLinkedListTests
{
    [Fact]
    public void _10_DesignDoublyLinkedList_ShouldHaveExpectedShape_ForScenario1()
    {
        // Arrange
        var list = new _10_DesignDoublyLinkedList();
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
    public void _10_DesignDoublyLinkedList_ShouldHaveExpectedShape_ForScenario2()
    {
        // Arrange
        var list = new _10_DesignDoublyLinkedList();
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
    public void _10_DesignDoublyLinkedList_ShouldHaveExpectedShape_ForScenario3()
    {
        // Arrange
        var list = new _10_DesignDoublyLinkedList();
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