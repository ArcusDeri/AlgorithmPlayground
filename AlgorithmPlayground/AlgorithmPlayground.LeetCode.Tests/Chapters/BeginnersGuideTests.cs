﻿using AlgorithmPlayground.LeetCode.Chapters.BeginnersGuide;
using AlgorithmPlayground.LeetCode.Model;
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

    [Theory]
    [InlineData(new[] {"1", "2", "Fizz"}, 3)]
    [InlineData(new[] {"1", "2", "Fizz", "4", "Buzz"}, 5)]
    [InlineData(
        new[] {"1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz"},
        15)]
    public void _3_412_FizzBuzz_ShouldReturnExpectedResult(string[] expectedResult, int n)
    {
        // Arrange
        // Act
        var result = _3_412_FizzBuzz.FizzBuzz(n);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [InlineData(6, 14)]
    [InlineData(4, 8)]
    [InlineData(12, 123)]
    public void _4_1342_NumberOfSteps_ShouldReturnExpectedResult(int expected, int num)
    {
        // Arrange
        // Act
        var result = _4_1342_NumberOfStepsToReduceANumberToZero.NumberOfSteps(num);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void _5_876_MiddleNode_ShouldReturnExpectedResult_v1()
    {
        // Arrange
        var expected = new ListNode(3, new ListNode(4, new ListNode(5)));
        var input = new ListNode(1, new ListNode(2, expected));

        // Act
        var result = _5_876_MiddleOfTheLinkedList.MiddleNode(input);

        // Assert
        Assert.Same(expected, result);
    }

    [Fact]
    public void _5_876_MiddleNode_ShouldReturnExpectedResult_v2()
    {
        // Arrange
        var expected = new ListNode(4, new ListNode(5, new ListNode(6)));
        var input = new ListNode(1, new ListNode(2, new ListNode(3, expected)));

        // Act
        var result = _5_876_MiddleOfTheLinkedList.MiddleNode(input);

        // Assert
        Assert.Same(expected, result);
    }

    [Theory]
    [InlineData(false, "a", "b")]
    [InlineData(false, "aa", "ab")]
    [InlineData(true, "aa", "aab")]
    [InlineData(true, "aab", "baa")]
    public void _6_383_CanConstruct_ShouldReturnExpectedResult(bool expected, string ransomNote, string magazine)
    {
        // Arrange
        // Act
        var result = _6_383_RansomNote.CanConstruct(ransomNote, magazine);

        // Assert
        Assert.Equal(expected, result);
    }
}