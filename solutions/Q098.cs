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
    public bool IsValidBST(TreeNode root) {
        if (root == null)
        {
            return true;
        }
        long previousValue = long.MinValue;
        Stack<TreeNode> stk = new Stack<TreeNode>();
        while (root != null)
        {
            stk.Push(root);
            root = root.left;
        }
        while (stk.Count > 0)
        {
            var node = stk.Pop();
            if (node.val <= previousValue)
            {
                return false;
            }
            previousValue = node.val;
            var right = node.right;
            while (right != null)
            {
                stk.Push(right);
                right = right.left;
            }
        }
        return true;
    }
}
