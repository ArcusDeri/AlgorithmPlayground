﻿using AlgorithmPlayground.LeetCode.Model;

namespace AlgorithmPlayground.LeetCode.Chapters.LinkedList;

public static class _11_MergeTwoSortedLists
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/linked-list/213/conclusion/1227/
    /// </summary>
    public static ListNode? MergeTwoLists(ListNode? list1, ListNode? list2)
    {
        var resultHead = new ListNode();
        var currentNode = resultHead;

        while (list1 is { } && list2 is { })
        {
            if (list1.val < list2.val)
            {
                currentNode.next = list1;
                list1 = list1.next;
            }
            else
            {
                currentNode.next = list2;
                list2 = list2.next;
            }

            currentNode = currentNode.next;
        }

        if (list1 is { })
        {
            currentNode.next = list1;
        }
        else if (list2 is { })
        {
            currentNode.next = list2;
        }

        return resultHead.next;
    }
}