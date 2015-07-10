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
    public int SumNumbers(TreeNode root) {
        if (root == null)
        {
            return 0;
        }
        int answer = 0;
        Sum(root, ref answer, 0);
        return answer;
    }

    private void Sum(TreeNode root, ref int answer, int current)
    {
        if (root.left == null && root.right == null) // leaf
        {
            answer += current * 10 + root.val;
        }
        if (root.left != null)
        {
            Sum(root.left, ref answer, current * 10 + root.val);
        }
        if (root.right != null)
        {
            Sum(root.right, ref answer, current * 10 + root.val);
        }
    }
}
