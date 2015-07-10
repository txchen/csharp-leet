/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode ReverseKGroup(ListNode head, int k) {
        ListNode preAnswer = new ListNode(0);
        var pre = preAnswer;
        pre.next = head;
        var start = head;
        var end = start;
        while (true)
        {
            for (int i = 0; i < k - 1 && end != null; i++)
            {
                end = end.next;
            }
            if (end == null)
            {
                break;
            }
            var nextStart = end.next;
            // 4 pointer here, pre -> start -> -> -> -> end -> nextStart
            while (start.next != nextStart)
            {
                // reverse in k group
                var temp = pre.next;
                pre.next = start.next;
                start.next = start.next.next;
                pre.next.next = temp;
            }
            // next round
            pre = start;
            start = pre.next;
            end = start;
        }
        return preAnswer.next;
    }
}
