/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public bool IsPalindrome(ListNode head) {
        if (head == null) {
            return true;
        }
        int length = 0;
        var tmp = head;
        while (tmp != null) {
            length++;
            tmp = tmp.next;
        }
        tmp = head;
        var stk = new Stack<int>();
        int position = 0;
        while (tmp != null) {
            if (position < length / 2) {
                stk.Push(tmp.val);
            } else if (position > (length - 1) / 2) {
                if (tmp.val != stk.Pop()) {
                    return false;
                }
            }
            tmp = tmp.next;
            position++;
        }
        return true;
    }
}
