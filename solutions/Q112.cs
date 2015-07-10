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
    public bool HasPathSum(TreeNode root, int sum) {
        if (root == null)
        {
            return false;
        }
        if (root.left == null && root.right == null)
        {
            return sum == root.val;
        }
        if (root.left != null && HasPathSum(root.left, sum - root.val))
        {
            return true;
        }
        if (root.right != null && HasPathSum(root.right, sum - root.val))
        {
            return true;
        }
        return false;
    }
}
