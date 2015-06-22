// Sort a linked list using insertion sort.
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode InsertionSortList(ListNode head) {
        var preA = new ListNode(0);
        while (head != null) {
            var pre = preA;
            while (pre.next != null && pre.next.val < head.val) {
                pre = pre.next;
            }
            var headNext = head.next;
            var preNext = pre.next;
            head.next = preNext;
            pre.next = head;
            head = headNext;
        }
        return preA.next;
    }
}
