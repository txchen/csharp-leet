/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        ListNode preAnswer = new ListNode(0);
        var temp = preAnswer;
        while (l1 != null && l2 != null)
        {
            if (l1.val < l2.val)
            {
                temp.next = new ListNode(l1.val);
                l1 = l1.next;
            }
            else
            {
                temp.next = new ListNode(l2.val);
                l2 = l2.next;
            }
            temp = temp.next;
        }
        if (l1 != null)
        {
            temp.next = l1;
        }
        if (l2 != null)
        {
            temp.next = l2;
        }
        return preAnswer.next;
    }
}
