using AlgorithmPlayground.LeetCode.Chapters.LinkedList;
using AlgorithmPlayground.LeetCode.Model;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.LinkedList;

public class _15_RotateListTests
{
    [Fact]
    public void _01_RotateRight_ShouldReturnListOfExpectedShape()
    {
        // Arrange
        var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        const int k = 2;
        var expectedValues = new[] {4, 5, 1, 2, 3};
        var resultValues = new int[expectedValues.Length];
        var i = 0;

        // Act
        var result = _15_RotateList.RotateRight(head, k);
        while (result is {})
        {
            resultValues[i++] = result.val;
            result = result.next;
        }

        // Assert
        Assert.Equal(expectedValues, resultValues);
    }

    [Fact]
    public void _02_RotateRight_ShouldReturnListOfExpectedShape()
    {
        // Arrange
        var head = new ListNode(0, new ListNode(1, new ListNode(2)));
        const int k = 4;
        var expectedValues = new[] {2, 0, 1};
        var resultValues = new int[expectedValues.Length];
        var i = 0;

        // Act
        var result = _15_RotateList.RotateRight(head, k);
        while (result is {})
        {
            resultValues[i++] = result.val;
            result = result.next;
        }

        // Assert
        Assert.Equal(expectedValues, resultValues);
    }

    [Fact]
    public void _03_RotateRight_ShouldReturnListOfExpectedShape()
    {
        // Arrange
        var head = new ListNode(1);
        const int k = 0;
        var expectedValues = new[] {1};
        var resultValues = new int[expectedValues.Length];
        var i = 0;

        // Act
        var result = _15_RotateList.RotateRight(head, k);
        while (result is {})
        {
            resultValues[i++] = result.val;
            result = result.next;
        }

        // Assert
        Assert.Equal(expectedValues, resultValues);
    }

    [Fact]
    public void _04_RotateRight_ShouldReturnListOfExpectedShape()
    {
        // Arrange
        var head = new ListNode(1);
        const int k = 1;
        var expectedValues = new[] {1};
        var resultValues = new int[expectedValues.Length];
        var i = 0;

        // Act
        var result = _15_RotateList.RotateRight(head, k);
        while (result is {})
        {
            resultValues[i++] = result.val;
            result = result.next;
        }

        // Assert
        Assert.Equal(expectedValues, resultValues);
    }
}