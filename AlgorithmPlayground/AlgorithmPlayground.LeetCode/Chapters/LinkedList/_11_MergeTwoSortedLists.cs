using AlgorithmPlayground.LeetCode.Model;

namespace AlgorithmPlayground.LeetCode.Chapters.LinkedList;

public static class _11_MergeTwoSortedLists
{
    public static ListNode? MergeTwoLists(ListNode? list1, ListNode? list2)
    {
        if (list1 is null && list2 is null)
        {
            return null;
        }

        if (list1 is null)
        {
            return list2;
        }

        if (list2 is null)
        {
            return list1;
        }

        if (list1.val > list2.val)
        {
            (list1, list2) = (list2, list1);
        }

        var resultHead = new ListNode();
        var currentNode = resultHead;

        while (list1 is { } || list2 is { })
        {
            currentNode.next = new ListNode();
            currentNode = currentNode.next;
            if (list1 is { } && list2 is { })
            {
                if (list1.val < list2.val)
                {
                    currentNode.val = list1.val;
                    list1 = list1.next;
                }
                else
                {
                    currentNode.val = list2.val;
                    list2 = list2.next;
                }
            }
            else if (list1 is { })
            {
                currentNode.val = list1.val;
                currentNode.next = list1.next;
                list1 = null;
            }
            else if (list2 is { })
            {
                currentNode.val = list2.val;
                currentNode.next = list2.next;
                list2 = null;
            }
        }

        return resultHead.next;
    }
}