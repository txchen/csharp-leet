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
    public bool IsBalanced(TreeNode root) {
        return MaxDepth(root) >= 0;
    }

    private int MaxDepth(TreeNode root) // if not balanced, return -1
    {
        if (root == null)
        {
            return 0;
        }
        int leftDepth = MaxDepth(root.left);
        int rightDepth = MaxDepth(root.right);
        if (Math.Abs(leftDepth - rightDepth) >= 2 || leftDepth == -1 || rightDepth == -1)
        {
            return -1;
        }
        return Math.Max(leftDepth, rightDepth) + 1;
    }
}
