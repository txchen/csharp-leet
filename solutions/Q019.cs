/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        var left = head;
        var right = head;
        while (n-- > 0)
        {
            right = right.next;
        }
        if (right == null)
        {
            return head.next;
        }
        while (right.next != null)
        {
            left = left.next;
            right = right.next;
        }
        left.next = left.next.next;
        return head;
    }
}
