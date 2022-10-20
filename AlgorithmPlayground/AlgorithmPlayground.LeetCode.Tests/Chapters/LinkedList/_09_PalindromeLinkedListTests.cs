using AlgorithmPlayground.LeetCode.Chapters.LinkedList._03_ClassicProblems;
using AlgorithmPlayground.LeetCode.Model;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.LinkedList;

public class _09_PalindromeLinkedListTests
{
    [Fact]
    public void _01_IsPalindrome_ShouldReturnTrue_ForPalindromicLinkedList()
    {
        // Arrange
        var head = new ListNode(1, new ListNode(2, new ListNode(2, new ListNode(1))));

        // Act
        var result = _09_PalindromeLinkedList.IsPalindrome(head);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void _02_IsPalindrome_ShouldReturnFalse_ForNonPalindromicLinkedList()
    {
        // Arrange
        var head = new ListNode(1, new ListNode(2));

        // Act
        var result = _09_PalindromeLinkedList.IsPalindrome(head);

        // Assert
        Assert.False(result);
    }
}