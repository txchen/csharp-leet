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
    public int KthSmallest(TreeNode root, int k) {
        int leftCount = NodeCount(root.left);
        if (leftCount >= k) {
            return KthSmallest(root.left, k);
        } else if (leftCount + 1 == k) {
            return root.val;
        } else {
            return KthSmallest(root.right, k - 1 - leftCount);
        }
    }

    private int NodeCount(TreeNode root) {
        if (root != null) {
            return 1 + NodeCount(root.left) + NodeCount(root.right);
        }
        return 0;
    }
}
