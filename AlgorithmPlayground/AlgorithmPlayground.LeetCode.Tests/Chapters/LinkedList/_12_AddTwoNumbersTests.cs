using AlgorithmPlayground.LeetCode.Chapters.LinkedList;
using AlgorithmPlayground.LeetCode.Model;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.LinkedList;

public class _12_AddTwoNumbersTests
{
    [Fact]
    public void _01_AddTwoNumbers_ShouldReturnExpectedSum()
    {
        // Arrange
        var expectedSum = new[] {7, 0, 8};
        var number1 = new ListNode(2, new ListNode(4, new ListNode(3)));
        var number2 = new ListNode(5, new ListNode(6, new ListNode(4)));
        var resultSum = new int[expectedSum.Length];
        var i = 0;

        // Act
        var result = _12_AddTwoNumbers.AddTwoNumbers(number1, number2);
        while (result is { })
        {
            resultSum[i++] = result.val;
            result = result.next;
        }

        // Assert
        Assert.Equal(expectedSum, resultSum);
    }

    [Fact]
    public void _02_AddTwoNumbers_ShouldReturnExpectedSum()
    {
        // Arrange
        const int expectedSum = 0;
        var number1 = new ListNode();
        var number2 = new ListNode();

        // Act
        var result = _12_AddTwoNumbers.AddTwoNumbers(number1, number2);

        // Assert
        Assert.NotNull(result);
        Assert.Null(result.next);
        Assert.Equal(expectedSum, result.val);
    }

    [Fact]
    public void _03_AddTwoNumbers_ShouldReturnExpectedSum()
    {
        // Arrange
        var expectedSum = new[] {8, 9, 9, 9, 0, 0, 0, 1};
        var number1 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))))));
        var number2 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))));
        var i = 0;
        var resultSum = new int[expectedSum.Length];

        // Act
        var result = _12_AddTwoNumbers.AddTwoNumbers(number1, number2);
        while (result is { })
        {
            resultSum[i++] = result.val;
            result = result.next;
        }

        // Assert
        Assert.Equal(expectedSum, resultSum);
    }

    [Fact]
    public void _04_AddTwoNumbers_ShouldReturnExpectedSum()
    {
        // Arrange
        var expectedSum = new[] {2, 0, 1};
        var number1 = new ListNode(8, new ListNode(9));
        var number2 = new ListNode(4);
        var i = 0;
        var resultSum = new int[expectedSum.Length];

        // Act
        var result = _12_AddTwoNumbers.AddTwoNumbers(number1, number2);
        while (result is { })
        {
            resultSum[i++] = result.val;
            result = result.next;
        }

        // Assert
        Assert.Equal(expectedSum, resultSum);
    }
}