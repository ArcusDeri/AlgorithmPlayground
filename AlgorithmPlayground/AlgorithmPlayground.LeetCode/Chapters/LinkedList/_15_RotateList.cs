using AlgorithmPlayground.LeetCode.Model;

namespace AlgorithmPlayground.LeetCode.Chapters.LinkedList;

public static class _15_RotateList
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/linked-list/213/conclusion/1295/
    /// </summary>
    public static ListNode? RotateRight(ListNode? head, int k)
    { 
        var listLength = 0;
        var front = head;

        // resolve list length
        while (front is {})
        {
            listLength++;
            front = front.next;
        }

        if (listLength == 0)
        {
            return null;
        }

        k = k >= listLength ? k % listLength : k;
        if (k == 0)
        {
            return head;
        }

        front = head;
        var distance = 0;
        // move one pointer ahead to maintain the distance
        while (distance < k)
        {
            front = front.next;
            distance++;
        }

        var back = head;
        // find node that has to be detached...
        while (front?.next is {})
        {
            back = back.next;
            front = front.next;
        }

        // ...and move it to the beginning
        var newHead = back.next;
        back.next = null;
        front.next = head;

        return newHead;
    }
}