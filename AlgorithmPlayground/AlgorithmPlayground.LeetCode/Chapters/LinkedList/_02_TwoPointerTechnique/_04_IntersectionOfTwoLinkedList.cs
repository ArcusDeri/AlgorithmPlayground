using AlgorithmPlayground.LeetCode.Model;

namespace AlgorithmPlayground.LeetCode.Chapters.LinkedList._02_TwoPointerTechnique;

public static class _04_IntersectionOfTwoLinkedList
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/linked-list/214/two-pointer-technique/1215/
    /// Smart version shared by other Leetcode user.
    /// </summary>
    public static ListNode? GetIntersectionNode(ListNode headA, ListNode headB)
    {
        var currentA = headA;
        var currentB = headB;

        while (currentA != currentB){
            currentA = currentA == null ? headB : currentA.next;
            currentB = currentB == null ? headA : currentB.next;
        }
        return currentA;
    }

    /// <summary>
    /// First attempt to solve the problem. 
    /// </summary>
    public static ListNode? GetIntersectionNodeBeforeRefactor(ListNode headA, ListNode headB)
    {
        var hasInterSection = false;
        var currentA = headA;
        var currentB = headB;
        int aLength = 0, bLength = 0;

        while (currentA is {})
        {
            aLength++;
            currentA = currentA.next;
        }
        while (currentB is {})
        {
            bLength++;
            currentB = currentB.next;
        }

        var lengthDifference = aLength - bLength;
        var listToShift = headA;
        var notShiftedList = headB;
        if (lengthDifference < 0)
        {
            listToShift = headB;
            notShiftedList = headA;
            lengthDifference *= -1;
        }

        var position = 0;
        while (position < lengthDifference)
        {
            listToShift = listToShift.next;
            position++;
        }

        while (listToShift != notShiftedList)
        {
            if (listToShift is null || notShiftedList is null)
            {
                return null;
            }

            listToShift = listToShift.next;
            notShiftedList = notShiftedList.next;
        }

        return listToShift;
    }
}