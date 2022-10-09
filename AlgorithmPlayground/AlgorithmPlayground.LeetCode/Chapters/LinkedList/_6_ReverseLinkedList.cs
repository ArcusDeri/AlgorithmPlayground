using AlgorithmPlayground.LeetCode.Model;

namespace AlgorithmPlayground.LeetCode.Chapters.LinkedList;

public static class _6_ReverseLinkedList
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/linked-list/219/classic-problems/1204/
    /// </summary>
    public static ListNode? ReverseList(ListNode? head)
    {
        ListNode? newHead = null;
        while (head != null)
        {
            var sublist = head.next;
            head.next = newHead;
            newHead = head;
            head = sublist;
        }
        return newHead;
    }
}