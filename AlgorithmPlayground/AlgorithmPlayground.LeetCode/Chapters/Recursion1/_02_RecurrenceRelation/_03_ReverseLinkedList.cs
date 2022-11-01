using AlgorithmPlayground.LeetCode.Model;

namespace AlgorithmPlayground.LeetCode.Chapters.Recursion1._02_RecurrenceRelation
{
    public static class _03_ReverseLinkedList
    {
        /// <summary>
        /// https://leetcode.com/explore/learn/card/recursion-i/251/scenario-i-recurrence-relation/2378/
        /// </summary>
        public static ListNode? ReverseList(ListNode? head)
        {
            return InternalReverse(null, head);
        }

        private static ListNode? InternalReverse(ListNode? newHead, ListNode? rest)
        {
            if (rest is null)
            {
                return newHead;
            }
            var subList = rest.next;
            rest.next = newHead;
            return InternalReverse(rest, subList);
        }
    }
}