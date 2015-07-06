/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        var result = new ListNode(0);
        var tmp = result;
        int carry = 0;
        while (carry > 0 || l1 != null || l2 != null) {
            int newValue = carry + (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val);
            carry = newValue / 10;
            tmp.next = new ListNode(newValue % 10);
            tmp = tmp.next;
            l1 = l1 == null ? null : l1.next;
            l2 = l2 == null ? null : l2.next;
        }
        return result.next;
    }
}
