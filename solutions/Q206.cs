/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode ReverseList(ListNode head) {
        var preA = new ListNode(0);
        preA.next = head;
        while (head != null && head.next != null) {
            var hn = head.next;
            head.next = hn.next;
            var pn = preA.next;
            preA.next = hn;
            hn.next = pn;
        }
        return preA.next;
    }
}
