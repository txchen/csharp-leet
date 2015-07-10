/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode Partition(ListNode head, int x) {
        ListNode preA = new ListNode(0);
        preA.next = head;
        var write = preA;
        var scan = preA;
        while (scan != null && scan.next != null)
        {
            if (scan.next.val < x) // then swap write.Next and scan.Next
            {
                if (write != scan)
                {
                    var wn = write.next;
                    var snn = scan.next.next;
                    write.next = scan.next;
                    write.next.next = wn;
                    scan.next = snn;
                    write = write.next; // hard to write right
                    continue;
                }
                write = write.next;
            }
            scan = scan.next;
        }
        return preA.next;
    }
}
