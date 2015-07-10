/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode SwapPairs(ListNode head) {
        ListNode preAnswer = new ListNode(0);
        preAnswer.next = head;
        var left = preAnswer;
        while (left.next != null && left.next.next != null)
        {
            var right = left.next.next;
            left.next.next = right.next;
            right.next = left.next;
            left.next = right;
            left = right.next;
        }
        return preAnswer.next;
    }
}
