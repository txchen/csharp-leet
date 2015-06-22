// Sort a linked list in O(n log n) time using constant space complexity.

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode SortList(ListNode head)
    {
        if (head == null || head.next == null)
        {
            return head;
        }
        ListNode preA = new ListNode(0);
        preA.next = head;
        int length = 0;
        while (head != null)
        {
            length++;
            head = head.next;
        }

        for (int step = 1; step < length; step <<= 1)
        {
            head = preA.next;
            var pre = preA;
            while (head != null)
            {
                var la = Split(ref head, step);
                var lb = Split(ref head, step);
                var t = Merge(la, lb, head);
                pre.next = t.Item1;
                pre = t.Item2;
            }
        }
        return preA.next;
    }

    private ListNode Split(ref ListNode head, int step)
    {
        if (head == null)
        {
            return head;
        }
        ListNode result = head;
        while (step > 1 && head.next != null)
        {
            head = head.next;
            step--;
        }
        var temp = head.next;
        head.next = null;
        head = temp;
        return result;
    }

    private Tuple<ListNode, ListNode> Merge(ListNode a, ListNode b, ListNode tail)
    {
        ListNode preA = new ListNode(0);
        var cur = preA;
        while (a != null && b != null)
        {
            if (a.val < b.val)
            {
                cur.next = a;
                cur = a;
                a = a.next;
            }
            else
            {
                cur.next = b;
                cur = b;
                b = b.next;
            }
        }
        var remaining = a != null ? a : b;
        while (remaining != null)
        {
            cur.next = remaining;
            cur = remaining;
            remaining = remaining.next;
        }
        cur.next = tail;
        return Tuple.Create(preA.next, cur);
    }
}
