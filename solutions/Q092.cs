/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode ReverseBetween(ListNode head, int m, int n) {
        ListNode preA = new ListNode(0);
        preA.next = head;
        var pre = preA;
        int changeLength = n  -m;
        // first, move pre to the m-1 th node
        while (m-- > 1)
        {
            pre = pre.next;
        }
        var cur = pre.next;
        for (int i = 0; i < changeLength; i++)
        {
            // swap changeLength times, move the cur.Next to next of pre
            var pn = pre.next;
            var cn = cur.next;
            cur.next = cn.next;
            pre.next = cn;
            cn.next = pn;
        }

        return preA.next;
    }
}
