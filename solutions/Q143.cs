public class Solution {
    public void ReorderList(ListNode head) {
        if (head == null || head.next == null || head.next.next == null) {
            return;
        }
        var mid = head;
        var fast = head.next;
        while (fast != null && fast.next != null) {
            mid = mid.next;
            fast = fast.next.next;
        }
        // now reverse the node after mid
        var temp = mid.next;
        while (temp.next != null) {
            var mn = mid.next;
            mid.next = temp.next;
            temp.next = temp.next.next;
            mid.next.next = mn;
        }
        // now combine
        while (mid.next != null && mid != head) {
            var mn = mid.next;
            mid.next = mn.next;
            var hn = head.next;
            head.next = mn;
            mn.next = hn;
            head = hn;
        }
    }
}
