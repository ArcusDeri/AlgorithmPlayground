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
        var carry = 0;

        while (l1 is {} || l2 is {})
        {
            var firstNumber = l1?.val ?? 0;
            var secondNumber = l2?.val ?? 0;
            var subSum = firstNumber + secondNumber + carry;
            carry = subSum > 9 ? 1 : 0;
            currentNode.next = new ListNode(subSum % 10);
            currentNode = currentNode.next;
            l1 = l1?.next;
            l2 = l2?.next;
        }

        if (carry > 0)
        {
            currentNode.next = new ListNode(carry);
        }

        return dummyHead.next;
    }
}