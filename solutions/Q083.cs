/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        ListNode preA = new ListNode(0);
        preA.next = head;
        var start = head;
        var scan = head;
        while (scan != null)
        {
            if (scan.val != start.val)
            {
                start = start.next;
                start.val = scan.val;
            }
            scan = scan.next;
        }
        if (start != null)
        {
            start.next = null;
        }
        return preA.next;
    }
}
