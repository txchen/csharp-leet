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
    public bool IsSymmetric(TreeNode root) {
        // means left->right inorder and right-left inorder, outputs are same
        Stack<TreeNode> stk1 = new Stack<TreeNode>(); // l -> r
        Stack<TreeNode> stk2 = new Stack<TreeNode>(); // r -> l
        var root1 = root;
        while (root1 != null)
        {
            stk1.Push(root1);
            root1 = root1.left;
        }
        var root2 = root;
        while (root2 != null)
        {
            stk2.Push(root2);
            root2 = root2.right;
        }
        while (stk1.Count > 0 && stk1.Count == stk2.Count)
        {
            var node1 = stk1.Pop();
            var node2 = stk2.Pop();
            if (node1.val != node2.val)
            {
                return false;
            }
            node1 = node1.right;
            while (node1 != null)
            {
                stk1.Push(node1);
                node1 = node1.left;
            }
            node2 = node2.left;
            while (node2 != null)
            {
                stk2.Push(node2);
                node2 = node2.right;
            }
        }
        return stk1.Count == stk2.Count;
    }
}
