using AlgorithmPlayground.LeetCode.Model;

namespace AlgorithmPlayground.LeetCode.Chapters.LinkedList._03_ClassicProblems;

public static class _08_OddEvenLinkedList
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/linked-list/219/classic-problems/1208/
    /// </summary>
    public static ListNode? OddEvenList(ListNode? head)
    {
        if (head is null)
        {
            return null;
        }

        var currentOddNode = head;
        var currentEvenNode = head.next;
        var evenHead = head.next;

        while (currentEvenNode is {next: { }})
        {
            currentOddNode.next = currentEvenNode.next;
            currentOddNode = currentOddNode.next;
            currentEvenNode.next = currentOddNode.next;
            currentEvenNode = currentEvenNode.next;
        }

        currentOddNode.next = evenHead;
        return head;
    }
}