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
    public TreeNode BuildTree(int[] inorder, int[] postorder) {
        return BuildTree(inorder, 0, inorder.Length - 1, postorder, 0, postorder.Length - 1);
    }

    private TreeNode BuildTree(int[] inOrder, int inStart, int inEnd, int[] postOrder, int postStart, int postEnd)
    {
        if (postStart > postEnd || inStart > inEnd)
        {
            return null;
        }
        TreeNode root = new TreeNode(postOrder[postEnd]);
        // find where is the root in inorder
        int i = inStart;
        for (; i <= inEnd; i++)
        {
            if (inOrder[i] == postOrder[postEnd])
            {
                break;
            }
        }
        root.left = BuildTree(inOrder, inStart, i - 1, postOrder, postStart, postStart + i - inStart - 1);
        root.right = BuildTree(inOrder, i + 1, inEnd, postOrder, postStart + i - inStart, postEnd - 1);
        return root;
    }
}
