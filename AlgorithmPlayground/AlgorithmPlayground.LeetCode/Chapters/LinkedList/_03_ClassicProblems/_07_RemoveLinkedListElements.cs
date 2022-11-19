using AlgorithmPlayground.LeetCode.Model;

namespace AlgorithmPlayground.LeetCode.Chapters.LinkedList._03_ClassicProblems;

public static class _07_RemoveLinkedListElements
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

    /// <summary>
    /// Another approach with time complexity O(n) and space complexity O(n)
    /// </summary>
    public static ListNode? RemoveElementsRecursively(ListNode? head, int val)
    {
        if (head is null){
            return head;
        }
        head.next = RemoveElementsRecursively(head.next, val);
        return head.val == val ? head.next : head;
    }
}