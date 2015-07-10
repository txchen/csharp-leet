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
    public void Flatten(TreeNode root) {
        root = FlattenInt(root);
    }

    public TreeNode FlattenInt(TreeNode root)
    {
        if (root == null)
        {
            return null;
        }
        var right = root.right;
        var flattenedLeft = FlattenInt(root.left);
        root.left = null;
        root.right = flattenedLeft;
        var tmp = root;
        while (tmp.right != null)
        {
            tmp = tmp.right;
        }
        tmp.right = FlattenInt(right);
        return root;
    }
}
