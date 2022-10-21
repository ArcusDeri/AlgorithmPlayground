using AlgorithmPlayground.LeetCode.Chapters.BeginnersGuide._01_ChallengeProblems;
using AlgorithmPlayground.LeetCode.Model;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.BeginnersGuide;

public class _05_876_MiddleOfTheLinkedListTests
{
    [Fact]
    public void MiddleNode_ShouldReturnExpectedResult_v1()
    {
        // Arrange
        var expected = new ListNode(3, new ListNode(4, new ListNode(5)));
        var input = new ListNode(1, new ListNode(2, expected));

        // Act
        var result = _05_876_MiddleOfTheLinkedList.MiddleNode(input);

        // Assert
        Assert.Same(expected, result);
    }

    [Fact]
    public void MiddleNode_ShouldReturnExpectedResult_v2()
    {
        // Arrange
        var expected = new ListNode(4, new ListNode(5, new ListNode(6)));
        var input = new ListNode(1, new ListNode(2, new ListNode(3, expected)));

        // Act
        var result = _05_876_MiddleOfTheLinkedList.MiddleNode(input);

        // Assert
        Assert.Same(expected, result);
    }
}