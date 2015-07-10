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
        int pVal = p.val;
        int qVal = q.val;
        int rVal = root.val;
        if (pVal < rVal && qVal < rVal) {
            return LowestCommonAncestor(root.left, p, q);
        } else if (pVal > rVal && qVal > rVal) {
            return LowestCommonAncestor(root.right, p, q);
        }
        return root;
    }
}
