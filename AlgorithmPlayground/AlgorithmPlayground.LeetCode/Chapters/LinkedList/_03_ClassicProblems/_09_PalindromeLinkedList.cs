using AlgorithmPlayground.LeetCode.Model;

namespace AlgorithmPlayground.LeetCode.Chapters.LinkedList._03_ClassicProblems;

public static class _09_PalindromeLinkedList
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/linked-list/219/classic-problems/1209/
    /// </summary>
    public static bool IsPalindrome(ListNode head)
    {
        var walker = new ListNode(0, head);
        var runner = head;

        while (runner?.next != null)
        {
            walker = walker.next;
            runner = runner.next.next;
        }

        var reversedHalfStart = Reverse(walker.next);
        var secondHalfPtr = reversedHalfStart;
        var result = true;
        var firstHalfEnd = walker;
        walker = head;

        while (result && secondHalfPtr is { })
        {
            if (secondHalfPtr.val != walker.val)
            {
                result = false;
            }
            walker = walker.next;
            secondHalfPtr = secondHalfPtr.next;
        }
        firstHalfEnd.next = Reverse(reversedHalfStart);

        return true;
    }

    public static bool IsPalindromeV1(ListNode head)
    {
        var values = new List<int>();
        var currentNode = head;

        while (currentNode is { })
        {
            values.Add(currentNode.val);
            currentNode = currentNode.next;
        }


        var i = 0;
        var j = values.Count - 1;
        while (i < j)
        {
            if (values[i++] != values[j--])
            {
                return false;
            }
        }

        return true;
    }

    public static ListNode Reverse(ListNode head)
    {
        ListNode? newHead = null;
        while (head is { })
        {
            var subList = head.next;
            head.next = newHead;
            newHead = head;
            head = subList;
        }
        return newHead;
    }
}