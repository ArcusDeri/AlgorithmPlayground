﻿using AlgorithmPlayground.LeetCode.Chapters.BeginnersGuide;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters;

public class BeginnersGuideTests
{
    [Theory]
    [InlineData(new[] {1, 3, 6, 10}, new[] {1, 2, 3, 4})]
    [InlineData(new[] {1, 2, 3, 4, 5}, new[] {1, 1, 1, 1, 1})]
    [InlineData(new[] {3, 4, 6, 16, 17}, new[] {3, 1, 2, 10, 1})]
    public void _1_1480_RunningSum_ShouldReturnExpectedResult(int[] expected, int[] nums)
    {
        // Arrange
        // Act
        var result = _1_1480_RunningSumOf1DArray.RunningSum(nums);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(6, new[] {1, 2, 3}, new[] {3, 2, 1})]
    [InlineData(10, new[] {1, 5}, new[] {7, 3}, new[] {3, 5})]
    [InlineData(17, new[] {2, 8, 7}, new[] {7, 1, 3}, new[] {1, 9, 5})]
    public void _2_1672_MaximumWealth_ShouldReturnExpectedResult(int expectedResult, params int[][] accounts)
    {
        // Arrange
        // Act
        var result = _2_1672_RichestCustomerWealth.MaximumWealth(accounts);

        // Assert
        Assert.Equal(expectedResult, result);
    }
}