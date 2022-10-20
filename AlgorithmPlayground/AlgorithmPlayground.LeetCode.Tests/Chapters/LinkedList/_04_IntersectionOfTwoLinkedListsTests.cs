using AlgorithmPlayground.LeetCode.Chapters.LinkedList._02_TwoPointerTechnique;
using AlgorithmPlayground.LeetCode.Model;
using Xunit;

namespace AlgorithmPlayground.LeetCode.Tests.Chapters.LinkedList;

public class _04_IntersectionOfTwoLinkedListsTests
{
    [Fact]
    public void _01_GetIntersectionNode_ShouldReturnCorrectNode_WhenGivenListHasIntersection_V1()
    {
        // Arrange
        var commonList = new ListNode(8, new ListNode(4, new ListNode(5)));
        var listA = new ListNode(4, new ListNode(1, commonList));
        var listB = new ListNode(5, new ListNode(6, new ListNode(1, commonList)));

        // Act
        var result = _04_IntersectionOfTwoLinkedList.GetIntersectionNode(listA, listB);

        // Assert
        Assert.Same(commonList, result);
    }

    [Fact]
    public void _02_GetIntersectionNode_ShouldReturnCorrectNode_WhenGivenListHasIntersection_V2()
    {
        // Arrange
        var commonList = new ListNode(2, new ListNode(4));
        var listA = new ListNode(1, new ListNode(9, new ListNode(1, commonList)));
        var listB = new ListNode(3, commonList);

        // Act
        var result = _04_IntersectionOfTwoLinkedList.GetIntersectionNode(listA, listB);

        // Assert
        Assert.Same(commonList, result);
    }

    [Fact]
    public void _03_GetIntersectionNode_ShouldReturnNull_WhenGivenListsHaveNoCommonPart()
    {
        // Arrange
        var listA = new ListNode(2, new ListNode(6, new ListNode(4)));
        var listB = new ListNode(1, new ListNode(5));

        // Act
        var result = _04_IntersectionOfTwoLinkedList.GetIntersectionNode(listA, listB);

        // Assert
        Assert.Null(result);
    }
}