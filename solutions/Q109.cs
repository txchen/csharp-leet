/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public TreeNode SortedListToBST(ListNode head) {
        if (head == null)
        {
            return null;
        }
        // get length first
        int length = 0;
        var tmp = head;
        while (tmp != null)
        {
            tmp = tmp.next;
            length++;
        }
        return SortListToBST(ref head, length); // must use ref here
    }

    private TreeNode SortListToBST(ref ListNode head, int length)
    {
        if (length <= 0)
        {
            return null;
        }
        TreeNode root = new TreeNode(0);
        int leftLength = length / 2;
        int rightLength = length - 1 - length / 2;
        root.left = SortListToBST(ref head, leftLength);
        root.val = head.val;
        head = head.next;
        root.right = SortListToBST(ref head, rightLength);
        return root;
    }
}
