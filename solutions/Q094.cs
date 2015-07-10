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
    public IList<int> InorderTraversal(TreeNode root) {
        var answer = new List<int>();
        InorderTraversalRecur(root, answer);
        return answer;
    }

    private void InorderTraversalRecur(TreeNode root, List<int> answer)
    {
        if (root != null)
        {
            InorderTraversalRecur(root.left, answer);
            answer.Add(root.val);
            InorderTraversalRecur(root.right, answer);
        }
    }
}
