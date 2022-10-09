using AlgorithmPlayground.LeetCode.Model;

namespace AlgorithmPlayground.LeetCode.Chapters.LinkedList;

public static class _7_RemoveLInkedListElements
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/linked-list/219/classic-problems/1207/
    /// </summary>
    public static ListNode? RemoveElements(ListNode? head, int val)
    {
        if (head is null)
        {
            return null;
        }

        var preHead = new ListNode(0, head);
        var currentNode = preHead;
        while (currentNode.next is {})
        {
            if (currentNode.next.val == val)
            {
                currentNode.next = currentNode.next.next;
            }
            else
            {
                currentNode = currentNode.next;
            }
        }

        return preHead.next;
    }
}