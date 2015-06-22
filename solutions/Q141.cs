/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        if (head == null) {
            return false;
        }
        var fast = head.next;
        while (head != null)
        {
            if (fast == head) {
                return true;
            }
            head = head.next;
            if (fast == null || fast.next == null || fast.next.next == null) {
                return false;
            }
            fast = fast.next.next;
        }
        return false;
    }
}
