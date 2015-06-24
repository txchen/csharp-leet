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
    public int CountNodes(TreeNode root) {
        if (root == null) {
            return 0;
        }
        int leftDepth = 0;
        TreeNode tmp = root;
        while (tmp != null) {
            leftDepth++;
            tmp = tmp.left;
        }
        int rightDepth = 0;
        tmp = root;
        while (tmp != null) {
            rightDepth++;
            tmp = tmp.right;
        }
        if (leftDepth == rightDepth) {
            return (int)Math.Pow(2, leftDepth) - 1;
        }
        return 1 + CountNodes(root.left) + CountNodes(root.right);
    }
}
