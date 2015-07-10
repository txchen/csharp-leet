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
        if (head == null)
        {
            return null;
        }
        ListNode preA = new ListNode(0);
        preA.next = head;
        var write = preA;
        var scan = head;
        while (scan != null)
        {
            if (write.next.val != scan.val)
            {
                if (write.next.next == scan) // no dup
                {
                    write = write.next;
                }
                else // dup
                {
                    write.next = scan;
                }
            }
            scan = scan.next;
        }
        if (write.next.next != null)
        {
            write.next = null;
        }
        return preA.next;
    }
}
