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
    public ListNode DetectCycle(ListNode head) {
        if (head == null) {
            return null;
        }
        var slow = head;
        var fast = head;
        while (slow != null)
        {
            slow = slow.next;
            if (fast == null || fast.next == null || fast.next.next == null) {
                return null;
            }
            fast = fast.next.next;
            if (fast == slow) {
                while (slow != head) {
                    slow = slow.next;
                    head = head.next;
                }
                return head;
            }
        }
        return null;
    }
}
