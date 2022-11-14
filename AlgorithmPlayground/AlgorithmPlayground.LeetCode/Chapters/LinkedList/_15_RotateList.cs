using AlgorithmPlayground.LeetCode.Model;

namespace AlgorithmPlayground.LeetCode.Chapters.LinkedList;

public static class _15_RotateList
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/linked-list/213/conclusion/1295/
    /// </summary>
    public static ListNode? RotateRight(ListNode? head, int k)
    {
        if (head is null || k == 0)
        {
            return head;
        }

        var listLength = 1;
        var front = head;

        // resolve list length
        while (front is {next: {}})
        {
            listLength++;
            front = front.next;
        }

        k %= listLength;
        if (k == 0)
        {
            return head;
        }

        front.next = head;
        var distance = 0;
        while (distance < listLength - k)
        {
            front = front.next;
            distance++;
        }

        head = front.next;
        front.next = null;

        return head;
    }
}