/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public void DeleteNode(ListNode node) {
        var next = node.next;
        while (next != null) {
            node.val = next.val;
            if (next.next != null) {
                node = next;
                next = node.next;
            } else {
                break;
            }
        }
        node.next = null;
    }
}
