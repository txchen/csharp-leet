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
    public void RecoverTree(TreeNode root) {
        if (root == null)
        {
            return;
        }
        TreeNode previousNode = null;
        TreeNode swapNodeA = null;
        TreeNode swapNodeB = null;
        Stack<TreeNode> stk = new Stack<TreeNode>();
        var head = root;
        while (head != null)
        {
            stk.Push(head);
            head = head.left;
        }
        while (stk.Count > 0)
        {
            var node = stk.Pop();
            if (previousNode != null && previousNode.val > node.val)
            {
                if (swapNodeA == null)
                {
                    swapNodeA = previousNode;
                }
                swapNodeB = node;
            }
            previousNode = node;
            var right = node.right;
            while (right != null)
            {
                stk.Push(right);
                right = right.left;
            }
        }
        int temp = swapNodeA.val;
        swapNodeA.val = swapNodeB.val;
        swapNodeB.val = temp;
    }
}
