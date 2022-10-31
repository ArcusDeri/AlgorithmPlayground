using AlgorithmPlayground.LeetCode.Model;

namespace AlgorithmPlayground.LeetCode.Chapters.Recursion1._01_PrincipleOfRecursion
{
    public static class _02_SwapNodesInPairs
    {
        /// <summary>
        /// https://leetcode.com/explore/learn/card/recursion-i/250/principle-of-recursion/1681/
        /// </summary>
        public static ListNode? SwapPairs(ListNode? head)
        {
            if (head?.next is null)
            {
                return head;
            }
            var subList = head.next.next;
            var newHead = head.next;
            newHead.next = head;
            head.next = SwapPairs(subList);
            return newHead;
        }
    }
}