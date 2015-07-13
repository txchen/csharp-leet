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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if (root == null) {
            return null;
        }
        var l = LowestCommonAncestor(root.left, p, q);
        if (l != null) {
            return l;
        }
        var r = LowestCommonAncestor(root.right, p, q);
        if (r != null) {
            return r;
        }
        if (CoversNode(root, p) && CoversNode(root, q)) {
            return root;
        }
        return null;
    }

    private bool CoversNode(TreeNode root, TreeNode p) {
        if (root == null) {
            return false;
        }
        if (root == p) {
            return true;
        }
        return CoversNode(root.left, p) || CoversNode(root.right, p);
    }
}
