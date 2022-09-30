using AlgorithmPlayground.LeetCode.Model;

namespace AlgorithmPlayground.LeetCode.Chapters.BeginnersGuide;

public static class _5_876_MiddleOfTheLinkedList
{
    /// <summary>
    /// https://leetcode.com/problems/middle-of-the-linked-list/ 
    /// </summary>
    public static ListNode MiddleNode(ListNode head)
    {
        var result = head;
        var end = head;

        while (end is {next: { }})
        {
            result = result.next;
            end = end.next.next;
        }

        return result;
    }
}
