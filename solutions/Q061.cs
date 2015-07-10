/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode RotateRight(ListNode head, int k) {
        if (head == null)
        {
            return head;
        }
        var end = head;
        int length = 1;
        while (end.next != null)
        {
            end = end.next;
            length++;
        }
        k = k % length; if (k == 0)
        {
            return head;
        }
        ListNode preK = new ListNode(0);
        preK.next = head;
        end = preK;
        while (k-- > 0)
        {
            end = end.next;
        }
        // move end to the end :)
        while (end.next != null)
        {
            end = end.next;
            preK = preK.next;
        }
        var answer = preK.next;
        end.next = head;
        preK.next = null;
        return answer;
    }
}
