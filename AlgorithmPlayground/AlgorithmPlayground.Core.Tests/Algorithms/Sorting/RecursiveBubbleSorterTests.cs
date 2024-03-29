﻿using System;
using AlgorithmPlayground.Core.Algorithms.Sorting;
using Xunit;

namespace AlgorithmPlayground.Core.Tests.Algorithms.Sorting;

public class RecursiveBubbleSorterTests
{
    [Theory]
    [InlineData(new [] {6, 5, 3, 1, 8, 7, 2, 4})]
    [InlineData(new [] {9, 8, 7, 6, 5, 4, 3, 2, 1, 0})]
    public void Sort_ShouldSortGivenArrayAndReturnOperationCount_WhenCalled(int[] unsorted)
    {
        // Arrange
        var sorted = new int[unsorted.Length];
        Array.Copy(unsorted, sorted, unsorted.Length);
        Array.Sort(sorted);
        
        // Act
        var operationCount = RecursiveBubbleSorter.Sort(unsorted);
        
        // Assert
        Assert.True(operationCount > 0);
        Assert.Equal(sorted, unsorted);
    }
}