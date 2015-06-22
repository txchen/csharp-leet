/**
 * Definition for singly-linked list with a random pointer.
 * public class RandomListNode {
 *     public int label;
 *     public RandomListNode next, random;
 *     public RandomListNode(int x) { this.label = x; }
 * };
 */
public class Solution {
    public RandomListNode CopyRandomList(RandomListNode head) {
        if (head == null) {
            return null;
        }
        var temp = head;
        while (temp != null) {
            RandomListNode n = new RandomListNode(temp.label);
            n.next = temp.next;
            temp.next = n;
            temp = n.next;
        }
        temp = head;
        while (temp != null) {
            if (temp.random != null) {
                temp.next.random = temp.random.next;
            }
            temp = temp.next.next;
        }
        temp = head;
        var answer = head.next;
        while (temp.next != null) {
            var n = temp.next;
            temp.next = n.next;
            temp = n;
        }
        return answer;
    }
}
