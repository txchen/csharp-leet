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
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        return BuildTree(preorder, 0, preorder.Length - 1, inorder, 0, inorder.Length - 1);
    }

    private TreeNode BuildTree(int[] preorder, int preStart, int preEnd, int[] inorder, int inStart, int inEnd)
    {
        if (preStart > preEnd || inStart > inEnd)
        {
            return null;
        }
        TreeNode root = new TreeNode(preorder[preStart]);
        // find where is the root in inorder
        int i = inStart;
        for (; i <= inEnd; i++)
        {
            if (inorder[i] == preorder[preStart])
            {
                break;
            }
        }
        root.left = BuildTree(preorder, preStart + 1, preStart + i - inStart, inorder, inStart, i - 1);
        root.right = BuildTree(preorder, preStart + i - inStart + 1, preEnd, inorder, i + 1, inEnd);
        return root;
    }
}
