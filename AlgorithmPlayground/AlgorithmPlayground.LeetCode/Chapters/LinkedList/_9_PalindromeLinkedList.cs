using AlgorithmPlayground.LeetCode.Model;

namespace AlgorithmPlayground.LeetCode.Chapters.LinkedList;

public static class _9_PalindromeLinkedList
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/linked-list/219/classic-problems/1209/
    /// </summary>
    public static bool IsPalindrome(ListNode head)
    {
        var values = new List<int>();
        var currentNode = head;

        while (currentNode is {})
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
}