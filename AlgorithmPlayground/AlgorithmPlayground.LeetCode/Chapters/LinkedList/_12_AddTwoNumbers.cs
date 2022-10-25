using AlgorithmPlayground.LeetCode.Model;

namespace AlgorithmPlayground.LeetCode.Chapters.LinkedList;

public static class _12_AddTwoNumbers
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/linked-list/213/conclusion/1228/
    /// </summary>
    public static ListNode? AddTwoNumbers(ListNode? l1, ListNode? l2)
    {
        var dummyHead = new ListNode();
        var currentNode = dummyHead;
        var overflow = 0;

        while (l1 is {} && l2 is {})
        {
            var subSum = l1.val + l2.val + overflow;
            overflow = subSum / 10;
            currentNode.next = new ListNode(subSum % 10);
            currentNode = currentNode.next;
            l1 = l1.next;
            l2 = l2.next;
        }

        var leftNode = l1 ?? l2;
        while (leftNode is { })
        {
            var subSum = leftNode.val + overflow;
            overflow = subSum / 10;
            currentNode.next = new ListNode(subSum % 10);
            currentNode = currentNode.next;
            leftNode = leftNode.next;
        }

        if (overflow > 0)
        {
            currentNode.next = new ListNode(overflow);
        }

        return dummyHead.next;
    }
}