using AlgorithmPlayground.LeetCode.Model;

namespace AlgorithmPlayground.LeetCode.Chapters.LinkedList;

public static class _5_RemoveNthNodeFromEndOfList
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/linked-list/214/two-pointer-technique/1296/
    /// </summary>
    public static ListNode? RemoveNthFromEnd(ListNode head, int n)
    {
        int i = 1, length = 1;
        var lastNode = head;
        var currentNode = head;

        while (lastNode.next is { })
        {
            lastNode = lastNode.next;
            length++;
        }

        if (length == n)
        {
            return head.next;
        }

        while (i < length - n)
        {
            currentNode = currentNode.next;
            i++;
        }

        if (i == 1 && n == 1 && length == 1)
        {
            return head.next;
        }

        currentNode.next = currentNode.next.next;
        
        return head;
    }
}