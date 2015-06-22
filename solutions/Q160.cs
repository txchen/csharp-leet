/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        int lenA = GetLength(headA);
        int lenB = GetLength(headB);
        while (lenB > lenA) {
            headB = headB.next;
            lenB--;
        }
        while (lenA > lenB) {
            headA = headA.next;
            lenA--;
        }
        while (headA != null) {
            if (headA == headB) {
                return headA;
            }
            headA= headA.next;
            headB = headB.next;
        }
        return null;
    }

    private int GetLength(ListNode node) {
        if (node == null) {
            return 0;
        }
        int answer = 0;
        while (node != null) {
            answer++;
            node = node.next;
        }
        return answer;
    }
}
