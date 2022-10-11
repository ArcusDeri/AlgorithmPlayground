using AlgorithmPlayground.LeetCode.Model;

namespace AlgorithmPlayground.LeetCode.Chapters.LinkedList;

public static class _5_RemoveNthNodeFromEndOfList
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/linked-list/214/two-pointer-technique/1296/
    /// </summary>
    public static ListNode? RemoveNthFromEnd(ListNode head, int n)
    {
        var gap = 0;
        var dummyHead = new ListNode(0, head);
        var slow = dummyHead;
        var fast = head;

        while (gap != n)
        {
            fast = fast.next;
            gap++;
        }

        while (fast is { })
        {
            slow = slow.next;
            fast = fast.next;
        }

        slow.next = slow.next.next;
        return dummyHead.next;
    }
}